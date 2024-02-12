namespace Delio_so
{
    partial class browser
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            toSearch = new TextBox();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(toSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 46);
            panel1.TabIndex = 0;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconButton3.IconColor = Color.FromArgb(102, 74, 186);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 24;
            iconButton3.Location = new Point(90, 10);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(33, 29);
            iconButton3.TabIndex = 3;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            iconButton2.IconColor = Color.FromArgb(102, 74, 186);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 24;
            iconButton2.Location = new Point(51, 10);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(33, 29);
            iconButton2.TabIndex = 2;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.FromArgb(102, 74, 186);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 24;
            iconButton1.Location = new Point(12, 10);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(33, 29);
            iconButton1.TabIndex = 1;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // toSearch
            // 
            toSearch.Location = new Point(134, 10);
            toSearch.Name = "toSearch";
            toSearch.Size = new Size(594, 27);
            toSearch.TabIndex = 0;
            toSearch.KeyPress += toSearch_KeyPress;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 46);
            webView.Name = "webView";
            webView.Size = new Size(744, 475);
            webView.TabIndex = 1;
            webView.ZoomFactor = 0.7D;
            webView.SourceChanged += webView_SourceChanged;
            // 
            // browser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(webView);
            Controls.Add(panel1);
            Name = "browser";
            Size = new Size(744, 521);
            Load += browser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private TextBox toSearch;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}
