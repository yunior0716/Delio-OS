using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delio_so
{
    public partial class browser : UserControl
    {
        public browser()
        {
            InitializeComponent();
        }

        string url = "https://www.google.com";

        private async Task Initialized()
        {
            await webView.EnsureCoreWebView2Async(null);
        }

        private void browser_Load(object sender, EventArgs e)
        {
            InitBrowser();
            toSearch.Text = url;



        }

        private async void InitBrowser()
        {
            await Initialized();

            if (Uri.TryCreate(url, UriKind.Absolute, out Uri resultUri))
            {
                webView.CoreWebView2.Navigate(url);
            }
            else
            {
                // La cadena no es una URL válida, mostrar un mensaje de error o realizar alguna acción adecuada
                MessageBox.Show("La cadena proporcionada no es una URL válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoForward();

        }

        private void toSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Buscar al presionar Enter
            if (e.KeyChar == (char)13)
            {
                url = toSearch.Text;
                InitBrowser();
            }

        }

        private void webView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            toSearch.Text = webView.CoreWebView2.Source;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoBack();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Reload();
        }
    }
}
