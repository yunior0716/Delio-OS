using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Delio_so
{
    public partial class DelioSO : Form
    {
        public DelioSO()
        {
            InitializeComponent();

            //Timer
            timer1.Interval = 1000; // 1000 milisegundos = 1 segundo
            timer1.Tick += Timer_Tick;
            timer1.Start(); // Iniciar el temporizador
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar el texto del Label con la hora actual
            string time = DateTime.Now.ToString("hh:mm tt");
            string date = DateTime.Now.ToString("d/M/yyyy");
            string datetime = $"{time}\n{date}";

            clock.Text = datetime;
        }

        private List<window> openWindows = new List<window>();


        private void trashcan_Click(object sender, EventArgs e)
        {
            window window = new window();
            desktop.Controls.Add(window);
            window.Location = new Point(100, 100);
            window.BringToFront();


        }


        private void notes_Click(object sender, EventArgs e)
        {
           Task.Run(() =>
            {
                // Crea una instancia del control de usuario
                // Iniciar un nuevo proceso para la ventana de notas
                window window = new window();
                notes notes = new notes();
                notes.Dock = DockStyle.Fill;
                Panel app_panel = window.Controls.Find("apppanel", true).FirstOrDefault() as Panel;
                window.changeName("Notes");
                app_panel.Controls.Add(notes);

                window.Location = new Point(120, 30);
                window.BringToFront();

                // Agrega la ventana a la lista de ventanas abiertas
                openWindows.Add(window);

                // Suscribe el manejador de eventos al evento CloseButtonClicked
                window.CloseButtonClicked += Window_CloseButtonClicked;

                // Invoca la creación del control de usuario en el subproceso de la interfaz de usuario principal
                Invoke((Action)(() =>
                {
                    // Agrega el control de usuario al formulario principal

                    desktop.Controls.Add(window);

                }));
            });
        }

        private void Window_CloseButtonClicked(object? sender, EventArgs e)
        {
            // Obtiene la ventana que ha activado el evento
            window window = sender as window;

            // Remueve la ventana de la lista y del escritorio
            openWindows.Remove(window);
            desktop.Controls.Remove(window);
        }

        private void clock_Click(object sender, EventArgs e)
        {

        }

        private void browser_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                // Crea una instancia del control de usuario
                // Iniciar un nuevo proceso para la ventana de notas
                window window = new window();
                browser browser = new browser();
                browser.Dock = DockStyle.Fill;
                Panel app_panel = window.Controls.Find("apppanel", true).FirstOrDefault() as Panel;
                window.changeName("Browser");
                app_panel.Controls.Add(browser);

                window.Location = new Point(120, 30);
                window.BringToFront();

                // Agrega la ventana a la lista de ventanas abiertas
                openWindows.Add(window);

                // Suscribe el manejador de eventos al evento CloseButtonClicked
                window.CloseButtonClicked += Window_CloseButtonClicked;

                // Invoca la creación del control de usuario en el subproceso de la interfaz de usuario principal
                Invoke((Action)(() =>
                {
                    // Agrega el control de usuario al formulario principal

                    desktop.Controls.Add(window);

                }));
            });
        }

        private void fileexplorer_MouseHover(object sender, EventArgs e)
        {
            fileexplorer.BackColor = Color.FromArgb(204, 204, 255);
        }

        private void fileexplorer_MouseLeave(object sender, EventArgs e)
        {
            fileexplorer.BackColor = Color.Transparent;
        }

        private void menu_MouseHover(object sender, EventArgs e)
        {
            menu.BackColor = Color.FromArgb(204, 204, 255);
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.BackColor = Color.Transparent;
        }

        private void browser_MouseHover(object sender, EventArgs e)
        {
            browser.BackColor = Color.FromArgb(204, 204, 255);
        }

        private void browser_MouseLeave(object sender, EventArgs e)
        {
            browser.BackColor = Color.Transparent;
        }

        private void notes_MouseHover(object sender, EventArgs e)
        {
            notes.BackColor = Color.FromArgb(204, 204, 255);
        }

        private void notes_MouseLeave(object sender, EventArgs e)
        {
            notes.BackColor = Color.Transparent;
        }

        private void musicplayer_MouseHover(object sender, EventArgs e)
        {
            musicplayer.BackColor = Color.FromArgb(204, 204, 255);
        }

        private void musicplayer_MouseLeave(object sender, EventArgs e)
        {
            musicplayer.BackColor = Color.Transparent;
        }

        private void taskmanager_MouseHover(object sender, EventArgs e)
        {
            taskmanager.BackColor = Color.FromArgb(204, 204, 255);
        }

        private void taskmanager_MouseLeave(object sender, EventArgs e)
        {
            taskmanager.BackColor = Color.Transparent;
        }

        private void trashcan_MouseHover(object sender, EventArgs e)
        {
            trashcan.BackColor = Color.FromArgb(204, 204, 255);
        }

        private void trashcan_MouseLeave(object sender, EventArgs e)
        {
            trashcan.BackColor = Color.Transparent;
        }
    }
}
