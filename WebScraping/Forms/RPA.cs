using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace WebScraping.Forms
{
    public partial class RPA : Telerik.WinControls.UI.RadForm
    {
        public string url = "https://www.phpscriptdemos.com/poll/admin/login.php?error=expired";
        public string curl = "https://www.phpscriptdemos.com/poll/admin/index.php?";
        public string url_ = "";

        public RPA()
        {
            InitializeComponent();
        }


        public void EnviarRequisicao(string username, string password)
        {
            try
            {
                string login = "https://www.phpscriptdemos.com/poll/admin/login_action.php";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(login);
                request.ContentType = "application/x-www-form-urlencoded";
                request.Method = "POST";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    // html encoding
                    streamWriter.Write($"username={tbUser.Text}&password={tbPassword.Text}");
                }

                string responseFromSever = String.Empty;

                HttpWebResponse response_ = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(response_.GetResponseStream()))
                {
                    responseFromSever = streamReader.ReadToEnd();
                    Debug.WriteLine(responseFromSever);
                }

                if (responseFromSever.Contains("error=error"))
                {
                    RadMessageBox.Show("Erro ao realizar a autenticação");
                    return;
                }

                RadMessageBox.Show("Autenticado");


            }

            catch (WebException e)
            {
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
                    using (Stream data = response.GetResponseStream())
                    using (var reader = new StreamReader(data))
                    {
                        string text = reader.ReadToEnd();
                        Console.WriteLine(text);
                    }
                }
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbUser.Text)) { RadMessageBox.Show("Gentileza preencher o campo "); return; }
            if (String.IsNullOrEmpty(tbPassword.Text)) { RadMessageBox.Show("Gentileza preencher o campo"); return; }

            EnviarRequisicao(tbUser.Text, tbPassword.Text);
        }
    }
}
