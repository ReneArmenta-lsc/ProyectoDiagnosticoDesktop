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

        private int RowSeleccionado = -1;

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
            command.Parameters.Add(new SqlParameter("@MostrarEliminados", CHBMostrarEliminados.Checked));

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)DGVClientes.Rows[0].Clone();

                    row.Cells[DGVClientes.Columns["Id"].Index].Value = reader.GetValue(reader.GetOrdinal("Id"));
                    row.Cells[DGVClientes.Columns["Nombres"].Index].Value = reader.GetValue(reader.GetOrdinal("Nombres"));
                    row.Cells[DGVClientes.Columns["ApellidoPaterno"].Index].Value = reader.GetValue(reader.GetOrdinal("ApellidoPaterno"));
                    row.Cells[DGVClientes.Columns["ApellidoMaterno"].Index].Value = reader.GetValue(reader.GetOrdinal("ApellidoMaterno"));
                    row.Cells[DGVClientes.Columns["Sexo"].Index].Value = reader.GetValue(reader.GetOrdinal("SexoNombre"));
                    row.Cells[DGVClientes.Columns["FechaNacimiento"].Index].Value = reader.GetValue(reader.GetOrdinal("FechaNacimiento"));
                    row.Cells[DGVClientes.Columns["Nacionalidad"].Index].Value = reader.GetValue(reader.GetOrdinal("NacionalidadNombre"));
                    row.Cells[DGVClientes.Columns["Activo"].Index].Value = reader.GetBoolean(reader.GetOrdinal("Activo"));

                    if (!Convert.ToBoolean(row.Cells[8].Value))
                    {
                        
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.Cells[7].Value = "Eliminar";
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
                Cliente cliente = new Cliente(sql,int.Parse(DGVClientes.Rows[e.RowIndex].Cells[0].Value.ToString()));
                cliente.ShowDialog();
            }
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(sql,IdActual());
            cliente.ShowDialog();

            Buscar();
        }

        private int IdActual()
        {

            sql.Open();
            SqlCommand command = new SqlCommand("ClienteIdActual", sql);
            command.CommandType = CommandType.StoredProcedure;
            int id = int.Parse(command.ExecuteScalar().ToString()) + 1;
            sql.Close();

            return id;        
        }

        private void DGVClientes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (RowSeleccionado == e.RowIndex || e.ColumnIndex > 6) return;
            RowSeleccionado = e.RowIndex;

            if (RowSeleccionado >= 0)
            {
                var cell = DGVClientes.PointToClient(Cursor.Position);
                toolTip1.Show("Doble clic para editar", DGVClientes,cell.X, cell.Y, 1000);
            }
            
        }

        private void DGVClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(senderGrid.Rows[e.RowIndex].Cells[8].Value))
                {
                    MessageBox.Show("Desea eliminar a " + senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString(), "Confirme", MessageBoxButtons.YesNo);
                }
            }
        }

        private void CHBMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
