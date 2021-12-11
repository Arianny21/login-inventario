using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDlogin
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        static string conexion = "SERVER=127.0.0.1; PORT=3306; DATABASE=bdlogin1; UID=root; PASSWORD=;";
        MySqlConnection cn = new MySqlConnection(conexion);

        public DataTable llenar_grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            String llenar = "Select * from productos";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();

            return dt;
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    textIdProducto.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    textNombreProducto.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    textMarca.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                    textCategoria.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                    textPrecio.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    textCantDispo.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                }
                catch
                {

                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();

            String insertar = "INSERT INTO productos(IDPRODUCTO, NOMBREPRODUCTO, MARCA, CATEGORIA, PRECIO, CANTDISPO)values(@idProducto, @nombreProducto, @marca, @categoria, @precio, @cantDispo)";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);

            cmd.Parameters.AddWithValue("@idProducto", textIdProducto.Text);
            cmd.Parameters.AddWithValue("@nombreProducto", textNombreProducto.Text);
            cmd.Parameters.AddWithValue("@marca", textMarca.Text);
            cmd.Parameters.AddWithValue("@categoria", textCategoria.Text);
            cmd.Parameters.AddWithValue("@precio", textPrecio.Text);
            cmd.Parameters.AddWithValue("@cantDispo", textCantDispo.Text);

            cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("Los datos fueron agregados exitosamente.");


            dataGridView2.DataSource = llenar_grid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            string modificar = "UPDATE productos SET IDPRODUCTO=@idProducto, NOMBREPRODUCTO=@nombreProducto, MARCA=@marca, CATEGORIA=@categoria, PRECIO=@precio, CANTDISPO=@cantDispo WHERE IDPRODUCTO=@idProducto";

            MySqlCommand cmd = new MySqlCommand(modificar, cn);

            cmd.Parameters.AddWithValue("@idProducto", textIdProducto.Text);
            cmd.Parameters.AddWithValue("@nombreProducto", textNombreProducto.Text);
            cmd.Parameters.AddWithValue("@marca", textMarca.Text);
            cmd.Parameters.AddWithValue("@categoria", textCategoria.Text);
            cmd.Parameters.AddWithValue("@precio", textPrecio.Text);
            cmd.Parameters.AddWithValue("@cantDispo", textCantDispo.Text);

            cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("Datos modificados correctamente");

            dataGridView2.DataSource = llenar_grid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();

            String eliminar = "DELETE FROM productos WHERE IDPRODUCTO=@idProducto";

            MySqlCommand cmd = new MySqlCommand(eliminar, cn);
            cmd.Parameters.AddWithValue("@idProducto", textIdProducto.Text);
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Los datos fueron borrados exitosamente.");

            dataGridView2.DataSource = llenar_grid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textIdProducto.Clear();
            textNombreProducto.Clear();
            textMarca.Clear();
            textCategoria.Clear();
            textPrecio.Clear();
            textCantDispo.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormLogin();
            formulario1.Show();
            this.Hide();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            FormPrincipal menu = new FormPrincipal();
            menu.Show();
            this.Hide();
        }
    }
    }
