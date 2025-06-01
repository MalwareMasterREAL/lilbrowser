using System.Windows.Forms;

namespace Lilbrowser
{
    partial class Form1
    {
        private System.Windows.Forms.WebBrowser Lilbrowser1;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel topPanel;

        private void InitializeComponent()
        {
            this.Lilbrowser1 = new System.Windows.Forms.WebBrowser();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();

            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Height = 40;
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Controls.Add(this.button2);
            this.topPanel.Controls.Add(this.button3);
            this.topPanel.Controls.Add(this.button4);
            this.topPanel.Controls.Add(this.addressBox);
            this.topPanel.Controls.Add(this.button5);

            // 
            // button1 (Back)
            // 
            this.button1.Location = new System.Drawing.Point(10, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 24);
            this.button1.Text = "Back";
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // button2 (Forward)
            // 
            this.button2.Location = new System.Drawing.Point(75, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 24);
            this.button2.Text = "Forward";
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // 
            // button3 (Refresh)
            // 
            this.button3.Location = new System.Drawing.Point(140, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 24);
            this.button3.Text = "Refresh";
            this.button3.Click += new System.EventHandler(this.button3_Click);

            // 
            // button4 (Google)
            // 
            this.button4.Location = new System.Drawing.Point(205, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 24);
            this.button4.Text = "Google";
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(270, 10);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(500, 20);

            // 
            // button5 (Go)
            // 
            this.button5.Location = new System.Drawing.Point(780, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 24);
            this.button5.Text = "Go";
            this.button5.Click += new System.EventHandler(this.button5_Click);

            // 
            // Lilbrowser1
            // 
            this.Lilbrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lilbrowser1.Location = new System.Drawing.Point(0, 40);
            this.Lilbrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.Lilbrowser1.Name = "Lilbrowser1";
            this.Lilbrowser1.TabIndex = 0;
            this.Lilbrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.Lilbrowser1_DocumentCompleted);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(924, 600);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.Lilbrowser1);
            this.Controls.Add(this.topPanel);
            this.Name = "Form1";
            this.Text = "Lilbrowser";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
