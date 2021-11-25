using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (ValidarCliente())
            {
                GuardarCliente();
                Close();
            }
        }

        private bool ValidarCliente()
        {
            string nombre = TXBNombre.Text.Trim();
            if (!ValidarTexto("Nombre", nombre,true)) return false;

            string apellidoPat = TXBApellidoPat.Text.Trim();
            if (!ValidarTexto("Apellido Paterno", apellidoPat,true)) return false;

            string apellidoMat = TXBApellidoMat.Text.Trim();
            if (!ValidarTexto("Apellido Materno", apellidoMat,true)) return false;

            if (!ValidarFecha(DTPFechaNacimiento.Value,true)) return false;

            return true;
        }

        private bool ValidarTexto(string nombre ,string text,bool mensajes)
        {
           
            if (text.Length == 0)
            {
                if (mensajes) MessageBox.Show(string.Format("El campo {0} no puede estar vacio", nombre));
                return false;
            }

            if (!Regex.IsMatch(text, @"^[a-zA-Z]+$"))
            {
                if (mensajes) MessageBox.Show(string.Format("El campo {0} no puede contener numeros ni caracteres especiales",nombre));
                return false;
            }

            return true;
        }

        private bool ValidarFecha(DateTime fecha, bool mensajes)
        {
            DateTime ahora = DateTime.Now;
            if (ahora.AddYears(-18) < fecha)
            {
                if (mensajes) MessageBox.Show(string.Format("Fecha de nacimiento no valida, el cliente debe ser mayor de edad"));
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
            sql.Open();
            SqlCommand command = new SqlCommand("Clienteguardar", sql);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Nombre", TXBNombre.Text));
            command.Parameters.Add(new SqlParameter("@ApellidoPat", TXBApellidoPat.Text));
            command.Parameters.Add(new SqlParameter("@ApellidoMat", TXBApellidoMat.Text));
            command.Parameters.Add(new SqlParameter("@Sexo", CBSexo.SelectedValue));
            command.Parameters.Add(new SqlParameter("@FechaNacimiento", DTPFechaNacimiento.Value));
            command.Parameters.Add(new SqlParameter("@Nacionalidad", CBNacionalidad.SelectedValue));
            command.Parameters.Add(new SqlParameter("@RFC", TXBRFC.Text));
            command.Parameters.Add(new SqlParameter("@Telefono", TXBTelefono.Text));
            command.Parameters.Add(new SqlParameter("@Email", TXBEmail.Text));
            command.ExecuteNonQuery();
            sql.Close();
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TXBNombre_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarTexto("", TXBNombre.Text.Trim(), false))
            {
                TXBNombre.BackColor = Color.Crimson;
            }
            else
            {
                TXBNombre.BackColor = Color.White;
            }
        }

        private void TXBApellidoPat_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarTexto("", TXBApellidoPat.Text.Trim(), false))
            {
                TXBApellidoPat.BackColor = Color.Crimson;
            }
            else
            {
                TXBApellidoPat.BackColor = Color.White;
            }
        }

        private void TXBApellidoMat_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarTexto("", TXBApellidoMat.Text.Trim(), false))
            {
                TXBApellidoMat.BackColor = Color.Crimson;
            }
            else
            {
                TXBApellidoMat.BackColor = Color.White;
            }
        }

        private void DTPFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidarFecha(DTPFechaNacimiento.Value, false))
            {
                panel1.BackColor = Color.Crimson;
            }
            else
            {
                panel1.BackColor = SystemColors.Control;
            }
        }
    }
}
