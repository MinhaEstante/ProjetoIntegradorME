using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace ProjetoIntegradorME
{
    public partial class Buscas : UserControl
    {

        /* Info and links:
  * Link to documentation:
  * https://developers.google.com/books/docs/v1/getting_started#REST 
  * Search Harry Potter by title:
  * https://www.googleapis.com/books/v1/volumes?q=intitle:%22harry+potter%22 
  * 
  * JSON breakdown for a single volume:
  * Bit of meta data; VolumeInfo - info on book; sale info - how much and site;
  * .....access info - country and viewability (PDF and EPUB); -- all ojObject parse
 */

        public const string myLib = "https://www.googleapis.com/books/v1/mylibrary/";
        public const string bookURL = "https://www.googleapis.com/books/v1/volumes/";

        HttpClient bookClient = new HttpClient();
        public Buscas()
        {
            InitializeComponent();
            bookClient.BaseAddress = new Uri(bookURL);
        }



        private void Buscas_Load(object sender, EventArgs e)
        {
            txtInfoBox.Text = "Insira um link de livro ou pesquise.";
            txtBuscas.Text = "";
            rbtnBuscar.Checked = true;


            // Add search items and select default
            string[] searchItems = new string[] { "Tudo", "Título", "Autor" };
            cbxProcura.Items.AddRange(searchItems);
            cbxProcura.SelectedItem = "Tudo";

            // Add results and select all items
            string[] resultItems = new string[] { "Título", "Sinopse", "Data de publicação", "Quantidade Página", "Autores", "Descrição" };
            resultsListBox.Items.AddRange(resultItems);
            for (int i = 0; i < resultsListBox.Items.Count; i++)
            {
                resultsListBox.SetItemChecked(i, true);
            }


        }


        // Search API Button



        // Parses the Json for the Book Info Box




        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBuscas.Text = "";

            string urlParameters;
            HttpResponseMessage response;

            if (rbtnSelecionarID.Checked)
            {
                urlParameters = txtBuscar.Text;//+ "?"
            }
            else
            //else if (radioVolumeSearch.Checked)
            {
                string searchFor = cbxProcura.SelectedItem.ToString();
                Console.WriteLine("Searching for " + searchFor);

                urlParameters = "?q="; // Search param

                if (searchFor == "author")
                {
                    urlParameters += "inauthor:" + txtBuscar.Text;
                }
                else if (searchFor == "title")
                {
                    urlParameters += "https://www.googleapis.com/books/v1/volumes?q=intitle:%22harry+potter%22";
                    urlParameters += "intitle:" + txtBuscar.Text;
                }
                else
                {
                    urlParameters += txtBuscar.Text;
                }


            }

            Console.WriteLine("User entered: " + urlParameters);
            response = bookClient.GetAsync(urlParameters).Result;

            if (response.IsSuccessStatusCode && rbtnSelecionarID.Checked)
            {
                JObject bookJson = JObject.Parse(response.Content.ReadAsStringAsync().Result); // Parses all Json content

                txtBuscas.Text = ParseBook(bookJson);
                txtInfoBox.Text = "Success: " + (int)response.StatusCode + " " + response.ReasonPhrase; // Infobox success code
            }
            else if (response.IsSuccessStatusCode && rbtnBuscar.Checked)
            {
                JObject bookJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);

                string text = "Number of records: " + bookJson["totalItems"].ToString() + "\r\n \r\n";



                JArray books = (JArray)bookJson["items"];

                StringBuilder sb = new StringBuilder();

                if (books != null)
                {
                    foreach (var book in books)
                    {
                        sb.Append(ParseBook((JObject)book) + "\r\n \r\n");

                        //avaliações / listbox - teste
                        //
                        lstAvaliac.Items.Add(book["id"].ToString() + " - " + book["volumeInfo"].ToString());

                        
                    }
                    txtBuscas.Text += sb.ToString();
                    //infoBox.Text = "Success: " + (int)response.StatusCode + " " + response.ReasonPhrase; // Infobox success code
                    txtInfoBox.Text = bookURL + urlParameters;




                }
                else
                {
                    txtInfoBox.Text = "Fail: Search didn't provide any valid results"; // Infobox fail code
                }

            }
            else
            {
                txtInfoBox.Text = "Fail: " + (int)response.StatusCode + " " + response.ReasonPhrase; // Infobox success code
            }
        }
        public string ParseBook(JObject bookJson)
        {
            Livros book = new Livros(); // Create the book object


            JObject volumeInfoObject = (JObject)bookJson["volumeInfo"]; // Reading book info for attributes
            JObject searchInfoObject = (JObject)bookJson["searchInfo"]; // Reading search info for blurb

            StringBuilder sb = new StringBuilder(); // Printing to screen

            bool[] resultBool = new bool[resultsListBox.Items.Count];
            for (int i = 0; i <= resultsListBox.Items.Count - 1; i++)
            {
                resultBool[i] = resultsListBox.GetItemChecked(i);
            }

            if (resultBool[0])
            {
                book.title = JsonUtilities.ParseJObject<string>(volumeInfoObject, "title");
                sb.Append("Title: " + book.title + " \r\n");
            }
            //if (resultBool[1])
            //{
            //    MatchCollection mc = Regex.Matches(bookJson["selfLink"].ToString(), "(?<=volumes/).*"); // Parsing ID
            //    foreach (Match m in mc)
            //    {
            //        book.id += m;
            //    }
            //    sb.Append("Volume ID: " + book.id + "\r\n");
            //}
            //if (resultBool[2])
            //{
            //    //Console.WriteLine("Search info object: " + searchInfoObject.ToString());
            //    book.blurb = JsonUtilities.ParseJObject<string>(searchInfoObject, "textSnippet");
            //    sb.Append("Blurb: " + book.blurb);
            //}
            //if (resultBool[3])
            //{
            //    book.publisher = JsonUtilities.ParseJObject<string>(volumeInfoObject, "publisher");
            //    sb.Append("Publisher: " + book.publisher + " \r\n");
            //}
            if (resultBool[1])
            {
                book.publishedDate = JsonUtilities.ParseJObject<string>(volumeInfoObject, "publishedDate");
                sb.Append("Published: " + book.publishedDate + " \r\n");
            }
            //if (resultBool[2])
            //{
            //    book.pagaCount = JsonUtilities.ParseJObject<int>(volumeInfoObject, "pagaCount");
            //    sb.Append("paga Count: " + book.pageCount + " \r\n");
            //}
            if (resultBool[3])
            {
                JArray authors = (JArray)volumeInfoObject["authors"];

                sb.Append("Authors: ");

                if (authors != null)
                {
                    foreach (var author in authors)
                    {
                        book.authors.Add(author.ToString());
                        sb.Append(author + ", ");
                    }

                }
                sb.Append("\r\n");

            }
            if (resultBool[4])
            {
                book.description = JsonUtilities.ParseJObject<string>(volumeInfoObject, "description");
                sb.Append(" \r\n");
                sb.Append("Description: " + book.description + " \r\n");
            }



            return sb.ToString();
        }

        private void resultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscas_TextChanged(object sender, EventArgs e)
        {

        }

        // Search box disabled when absolute value active
        //private void radioVolumeID_CheckedChanged(object sender, EventArgs e)
        //{
        //    searchComboBox.Enabled = false;
        //}

        //// Search box enabled when search active
        //private void radioVolumeSearch_CheckedChanged(object sender, EventArgs e)
        //{
        //    searchComboBox.Enabled = true;
        //}
    }
}
    

