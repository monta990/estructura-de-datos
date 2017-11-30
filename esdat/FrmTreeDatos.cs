using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace esdat
{
    public partial class FrmTreeDatos : Form
    {
        public static MySqlConnection mySqlConnection;
        public string cadena;
        public FrmTreeDatos()
        {
            InitializeComponent();
        }
        private void FrmTreeDatos_Load(object sender, EventArgs e)
        {
            tVdatos.Nodes.Add("Juegos");
            //treeView1.Nodes[0].Nodes[0].Nodes.Add("Campo 2 Values");
            //treeView1.Nodes[0].Nodes[0].Nodes.Add("Campo 3 Values");
            tVdatos.Nodes.Add("Developers");
            //treeView1.Nodes[1].Nodes.Add("Campo 1 Values Campo 2 Values");
            tVdatos.Nodes.Add("Players");
            //treeView1.Nodes[2].Nodes.Add("Campo 1 Values Campo 2 Values Campo 3 Values");
            tVdatos.Nodes.Add("Tablas integradora");
            //treeView1.Nodes[3].Nodes.Add("Campo 1 Values Campo 2 Values Campo 3 Values Campo 4 Values");
            tVdatos.Nodes.Add("Server Databases");
            Juegos();
            Developers();
            Players();
            Tables();
            Databases();
        }
        private void Juegos()
        {
            cadena = "Server=127.0.0.1;Database=games;Uid=root;Pwd=alvarez;"; //sin base de datos
            mySqlConnection = new MySqlConnection(cadena);
            try
            {
                string bd = "SELECT * FROM juegos";
                MySqlCommand mySqlCommand = new MySqlCommand(); //comando
                mySqlCommand.CommandText = bd; //comando a ejecutar
                mySqlConnection.Open();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.ExecuteNonQuery();
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    tVdatos.Nodes[0].Nodes.Add(lector.GetString(0));
                }
                lector.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Servidor Caido","Verifique el estado de la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void Developers()
        {
            cadena = "Server=127.0.0.1;Database=games;Uid=root;Pwd=alvarez;"; //sin base de datos
            mySqlConnection = new MySqlConnection(cadena);
            try
            {
                string bd = "SELECT * FROM developers";
                MySqlCommand mySqlCommand = new MySqlCommand(); //comando
                mySqlCommand.CommandText = bd; //comando a ejecutar
                mySqlConnection.Open();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.ExecuteNonQuery();
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    tVdatos.Nodes[1].Nodes.Add(lector.GetString(0)+" "+lector.GetString(1));
                }
                lector.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Servidor Caido", "Verifique el estado de la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void Players()
        {
            cadena = "Server=127.0.0.1;Database=games;Uid=root;Pwd=alvarez;"; //sin base de datos
            mySqlConnection = new MySqlConnection(cadena);
            try
            {
                string bd = "SELECT * FROM players";
                MySqlCommand mySqlCommand = new MySqlCommand(); //comando
                mySqlCommand.CommandText = bd; //comando a ejecutar
                mySqlConnection.Open();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.ExecuteNonQuery();
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    tVdatos.Nodes[2].Nodes.Add(lector.GetString(0) + " " + lector.GetString(1) + " " + lector.GetString(2));
                }
                lector.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Servidor Caido","Verifique el estado de la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void Tables()
        {
            cadena = "Server=127.0.0.1;Database=games;Uid=root;Pwd=alvarez;"; //sin base de datos
            mySqlConnection = new MySqlConnection(cadena);
            try
            {
                string bd = "SHOW TABLES FROM integradora";
                MySqlCommand mySqlCommand = new MySqlCommand(); //comando
                mySqlCommand.CommandText = bd; //comando a ejecutar
                mySqlConnection.Open();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.ExecuteNonQuery();
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    tVdatos.Nodes[3].Nodes.Add(lector.GetString(0));
                }
                lector.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Servidor Caido", "Verifique el estado de la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void Databases()
        {
            cadena = "Server=127.0.0.1;Database=games;Uid=root;Pwd=alvarez;"; //sin base de datos
            mySqlConnection = new MySqlConnection(cadena);
            try
            {
                string bd = "SHOW DATABASES";
                MySqlCommand mySqlCommand = new MySqlCommand(); //comando
                mySqlCommand.CommandText = bd; //comando a ejecutar
                mySqlConnection.Open();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.ExecuteNonQuery();
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read())
                {
                    tVdatos.Nodes[4].Nodes.Add(lector.GetString(0));
                }
                lector.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Servidor Caido", "Verifique el estado de la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
    }
}