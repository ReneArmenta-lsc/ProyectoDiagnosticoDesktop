using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiagnosticoDesktop
{
    public partial class Form1 : Form
    {
        private string conString = @"data source=AXEL\SQLEXPRESS;initial catalog = 'ProyectoDiagnostico'; persist security info = True;Integrated Security = SSPI;";
        SqlConnection sql;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql = new SqlConnection(conString);
            Buscar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            DGVClientes.AllowUserToAddRows = true;
            DGVClientes.Rows.Clear();
            sql.Open();

            SqlCommand command = new SqlCommand("ClienteBuscar", sql);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Text", "%"+TXBBuscar.Text+"%"));

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)DGVClientes.Rows[0].Clone();

                    for (int i = 0; i < DGVClientes.Columns.Count; i++)
                    {
                        row.Cells[i].Value = reader.GetValue(i).ToString();
                    }
                    DGVClientes.Rows.Add(row);
                }
            }
            reader.Close();
            sql.Close();
            DGVClientes.AllowUserToAddRows = false;
        }

        private void DGVClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cliente cliente = new Cliente(conString,int.Parse(DGVClientes.Rows[e.RowIndex].Cells[0].Value.ToString()));
                cliente.ShowDialog();
            }
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {


            Cliente cliente = new Cliente(conString,IdActual());
            cliente.ShowDialog();

            Buscar();
        }

        private int IdActual()
        {
            int id = 0;

            return id;        
        }
    }
}
