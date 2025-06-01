using System;
using System.Windows.Forms;

namespace Lilbrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lilbrowser1.ScriptErrorsSuppressed = true; // Suppress script error dialogs
        }

        private void Lilbrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Your logic here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Lilbrowser1.CanGoBack)
                Lilbrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Lilbrowser1.CanGoForward)
                Lilbrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lilbrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lilbrowser1.Navigate("https://www.google.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lilbrowser1.Navigate(addressBox.Text);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Lilbrowser1.Navigate("https://www.google.com");
        }
    }
}
