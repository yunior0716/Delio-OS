namespace Delio_so
{
    partial class window
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
            appname = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            apppanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(appname);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 37);
            panel1.TabIndex = 0;
            panel1.MouseClick += panel1_MouseClick;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // appname
            // 
            appname.AutoSize = true;
            appname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            appname.ForeColor = Color.FromArgb(102, 74, 186);
            appname.Location = new Point(16, 8);
            appname.Name = "appname";
            appname.Size = new Size(51, 20);
            appname.TabIndex = 3;
            appname.Text = "label1";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(102, 74, 186);
            iconButton2.ForeColor = Color.FromArgb(102, 74, 186);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            iconButton2.IconColor = Color.FromArgb(204, 204, 255);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 52;
            iconButton2.Location = new Point(868, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(43, 29);
            iconButton2.TabIndex = 1;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(204, 204, 255);
            iconButton1.ForeColor = Color.FromArgb(102, 74, 186);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton1.IconColor = Color.FromArgb(102, 74, 186);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton1.IconSize = 24;
            iconButton1.Location = new Point(819, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(43, 29);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // apppanel
            // 
            apppanel.Dock = DockStyle.Fill;
            apppanel.Location = new Point(0, 37);
            apppanel.Name = "apppanel";
            apppanel.Size = new Size(917, 565);
            apppanel.TabIndex = 1;
            // 
            // window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(apppanel);
            Controls.Add(panel1);
            Name = "window";
            Size = new Size(917, 602);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel apppanel;
        private Label appname;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
