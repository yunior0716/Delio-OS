namespace Delio_so
{
    partial class DelioSO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelioSO));
            desktop = new Panel();
            taskbar = new Panel();
            panel1 = new Panel();
            trashcan = new Label();
            musicplayer = new Label();
            taskmanager = new Label();
            browser = new Label();
            fileexplorer = new Label();
            notes = new Label();
            menu = new Label();
            clock = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            desktop.SuspendLayout();
            taskbar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // desktop
            // 
            desktop.BackColor = SystemColors.ActiveCaptionText;
            desktop.BackgroundImage = (Image)resources.GetObject("desktop.BackgroundImage");
            desktop.Controls.Add(taskbar);
            desktop.Dock = DockStyle.Fill;
            desktop.Location = new Point(0, 0);
            desktop.Name = "desktop";
            desktop.Size = new Size(1167, 704);
            desktop.TabIndex = 0;
            // 
            // taskbar
            // 
            taskbar.BackColor = Color.Lavender;
            taskbar.Controls.Add(panel1);
            taskbar.Controls.Add(menu);
            taskbar.Controls.Add(clock);
            taskbar.Dock = DockStyle.Bottom;
            taskbar.Location = new Point(0, 655);
            taskbar.Name = "taskbar";
            taskbar.Size = new Size(1167, 49);
            taskbar.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(trashcan);
            panel1.Controls.Add(musicplayer);
            panel1.Controls.Add(taskmanager);
            panel1.Controls.Add(browser);
            panel1.Controls.Add(fileexplorer);
            panel1.Controls.Add(notes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(70, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 49);
            panel1.TabIndex = 9;
            // 
            // trashcan
            // 
            trashcan.Anchor = AnchorStyles.Top;
            trashcan.BackColor = Color.Transparent;
            trashcan.Image = (Image)resources.GetObject("trashcan.Image");
            trashcan.Location = new Point(611, 6);
            trashcan.Name = "trashcan";
            trashcan.Size = new Size(49, 37);
            trashcan.TabIndex = 5;
            trashcan.Click += trashcan_Click;
            trashcan.MouseLeave += trashcan_MouseLeave;
            trashcan.MouseHover += trashcan_MouseHover;
            // 
            // musicplayer
            // 
            musicplayer.Anchor = AnchorStyles.Top;
            musicplayer.BackColor = Color.Transparent;
            musicplayer.Image = (Image)resources.GetObject("musicplayer.Image");
            musicplayer.Location = new Point(491, 6);
            musicplayer.Name = "musicplayer";
            musicplayer.Size = new Size(49, 37);
            musicplayer.TabIndex = 4;
            musicplayer.MouseLeave += musicplayer_MouseLeave;
            musicplayer.MouseHover += musicplayer_MouseHover;
            // 
            // taskmanager
            // 
            taskmanager.Anchor = AnchorStyles.Top;
            taskmanager.BackColor = Color.Transparent;
            taskmanager.Image = (Image)resources.GetObject("taskmanager.Image");
            taskmanager.Location = new Point(553, 6);
            taskmanager.Name = "taskmanager";
            taskmanager.Size = new Size(49, 37);
            taskmanager.TabIndex = 3;
            taskmanager.MouseLeave += taskmanager_MouseLeave;
            taskmanager.MouseHover += taskmanager_MouseHover;
            // 
            // browser
            // 
            browser.Anchor = AnchorStyles.Top;
            browser.BackColor = Color.Transparent;
            browser.Image = (Image)resources.GetObject("browser.Image");
            browser.Location = new Point(374, 6);
            browser.Name = "browser";
            browser.Size = new Size(49, 37);
            browser.TabIndex = 6;
            browser.Click += browser_Click;
            browser.MouseLeave += browser_MouseLeave;
            browser.MouseHover += browser_MouseHover;
            // 
            // fileexplorer
            // 
            fileexplorer.Anchor = AnchorStyles.Top;
            fileexplorer.BackColor = Color.Transparent;
            fileexplorer.Image = (Image)resources.GetObject("fileexplorer.Image");
            fileexplorer.Location = new Point(314, 6);
            fileexplorer.Name = "fileexplorer";
            fileexplorer.Size = new Size(49, 37);
            fileexplorer.TabIndex = 0;
            fileexplorer.MouseLeave += fileexplorer_MouseLeave;
            fileexplorer.MouseHover += fileexplorer_MouseHover;
            // 
            // notes
            // 
            notes.Anchor = AnchorStyles.Top;
            notes.BackColor = Color.Transparent;
            notes.Image = (Image)resources.GetObject("notes.Image");
            notes.Location = new Point(431, 6);
            notes.Name = "notes";
            notes.Size = new Size(49, 37);
            notes.TabIndex = 1;
            notes.Click += notes_Click;
            notes.MouseLeave += notes_MouseLeave;
            notes.MouseHover += notes_MouseHover;
            // 
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.Dock = DockStyle.Left;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(70, 49);
            menu.TabIndex = 8;
            menu.MouseLeave += menu_MouseLeave;
            menu.MouseHover += menu_MouseHover;
            // 
            // clock
            // 
            clock.Dock = DockStyle.Right;
            clock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clock.ForeColor = Color.FromArgb(102, 74, 186);
            clock.Location = new Point(1031, 0);
            clock.Name = "clock";
            clock.Size = new Size(136, 49);
            clock.TabIndex = 7;
            clock.Text = "Hola";
            clock.TextAlign = ContentAlignment.MiddleRight;
            clock.Click += clock_Click;
            // 
            // DelioSO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 704);
            Controls.Add(desktop);
            Name = "DelioSO";
            Text = "DelioSO";
            desktop.ResumeLayout(false);
            taskbar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel desktop;
        private Panel taskbar;
        private Label browser;
        private Label trashcan;
        private Label musicplayer;
        private Label taskmanager;
        private Label notes;
        private Label fileexplorer;
        private Label clock;
        private System.Windows.Forms.Timer timer1;
        private Label menu;
        private Panel panel1;
    }
}