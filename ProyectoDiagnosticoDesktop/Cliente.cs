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
    public partial class Cliente : Form
    {
        SqlConnection sql;
        int id;
        public Cliente(SqlConnection sql, int id)
        {
            this.sql = sql;
            this.id = id;
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            TXBId.Text = id.ToString();
            CargarSexos();
            CargarNacionalidades();
            CargarCliente();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCliente();
            }
        }

        private bool Validar()
        {
            string nombre = TXBNombre.Text.Trim();
            if (nombre.Length == 0)
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                return false;
            }

            return true;   
        }

        private void CargarCliente()
        {
            sql.Open();
            SqlCommand command = new SqlCommand("ClienteCargar", sql);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Id", id));

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TXBNombre.Text = reader.GetValue(reader.GetOrdinal("Nombres")).ToString();
                    TXBApellidoPat.Text = reader.GetValue(reader.GetOrdinal("ApellidoPaterno")).ToString(); ;
                    TXBApellidoMat.Text = reader.GetValue(reader.GetOrdinal("ApellidoMaterno")).ToString(); ;
                    CBSexo.SelectedValue = reader.GetValue(reader.GetOrdinal("Sexo"));
                    DTPFechaNacimiento.Value = DateTime.Parse(reader.GetValue(reader.GetOrdinal("FechaNacimiento")).ToString());
                    CBNacionalidad.SelectedValue = reader.GetValue(reader.GetOrdinal("Nacionalidad"));

                    TXBRFC.Text = reader.GetValue(reader.GetOrdinal("RFC")).ToString();
                    TXBTelefono.Text = reader.GetValue(reader.GetOrdinal("Telefono")).ToString();
                    TXBEmail.Text = reader.GetValue(reader.GetOrdinal("Email")).ToString();
                }
            }
            reader.Close();
            sql.Close();
        }

        private void CargarSexos()
        {
            DataSet ds = new DataSet();
            try
            {
                sql.Open();
                SqlDataAdapter SqlDa = new SqlDataAdapter("SexosCargar", sql);
                SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlDa.Fill(ds);
                sql.Close();
                CBSexo.DataSource = ds.Tables[0];
                CBSexo.DisplayMember = "Nombre";
                CBSexo.ValueMember = "Id";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void CargarNacionalidades()
        {
            DataSet ds = new DataSet();
            try
            {
                sql.Open();
                SqlDataAdapter SqlDa = new SqlDataAdapter("NacionalidadesCargar", sql);
                SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlDa.Fill(ds);
                sql.Close();
                CBNacionalidad.DataSource = ds.Tables[0];
                CBNacionalidad.DisplayMember = "Nombre";
                CBNacionalidad.ValueMember = "Id";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void GuardarCliente()
        {

        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
