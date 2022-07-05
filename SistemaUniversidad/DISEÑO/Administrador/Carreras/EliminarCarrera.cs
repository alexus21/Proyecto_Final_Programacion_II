﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SistemaUniversidad.DISEÑO.Menu;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Administrador.Carreras {
    public partial class EliminarCarrera : Form {
        public EliminarCarrera() {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EliminarCarrera_Load(object sender, EventArgs e) {
            LoadCareers();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desea salir?", "Atención", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
                this.Close();
            }
        }

        private void btnCancell_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desea salir?", "Atención", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
                this.Close();
            }
        }
    }
}
