using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiagnosticoDesktop
{
    public partial class Cliente : Form
    {
        string conString;
        int id;
        public Cliente(string conString, int id)
        {
            this.conString = conString;
            this.id = id;
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            TXBId.Text = id.ToString();


        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {

            }
        }

        private bool Validar()
        {
            return true;   
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
