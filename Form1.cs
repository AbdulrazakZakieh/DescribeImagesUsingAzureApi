using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescripeImagesUsingAPIs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		/// <summary>
		/// Read the bytes of a specific image
		/// </summary>
		/// <param name="imagePath"></param>
		/// <returns></returns>
		private byte[] getImageBytes(string imagePath)
		{
			using (FileStream fileStream = new FileStream(imagePath, FileMode.Open))
			{
				BinaryReader reader = new BinaryReader(fileStream);
				return reader.ReadBytes((int)fileStream.Length);
			}
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "PNG Images (*.png)|*.png|JPEG Images (*.jpeg)|*.jpeg" +
				"|GIF Images (*.gif)|*.gif|BMP Images (*.bmp)|*.bmp";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string imagePath = openFileDialog.FileName;
				byte[] imageBytes = getImageBytes(imagePath);
				imagePictureBox.Image = Image.FromFile(imagePath);
				// Defining new client
				HttpClient httpClient = new HttpClient();
				// Adding a parameter to the http request header (The subscription key: valid till 27. Dec. 2019)
				httpClient.DefaultRequestHeaders.Add(
					"ocp-apim-subscription-key", // parameter name
					"814d4923ad0e4ba3818884cf8df10c9a"); // parameter value
				// Defining the content for the http post body (the image's bytes as specified by the API's documentation)
				ByteArrayContent content =
					new ByteArrayContent(imageBytes);
				// specifiying the content type (From the API's documention)
				content.Headers.ContentType =
					new MediaTypeHeaderValue("application/octet-stream");
				HttpResponseMessage httpResponse =
					httpClient.PostAsync(
					"https://westcentralus.api.cognitive.microsoft.com/vision/v2.0/analyze?" +
					"visualFeatures=Description",
					content
					).Result;
				string responseString = httpResponse.Content.ReadAsStringAsync().Result;
				dynamic x =
					JsonConvert.DeserializeObject<dynamic>(responseString);
				string text = x.description.captions[0].text;
				descriptionLabel.Text = text;
			}
		}
    }
}
