using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace simpleCRUD
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            MySqlConnection con;

            try
            {
                //definir string de conexion
                connectionString = @"Server=localhost;Database=smis0000; Uid=root; 
                    Pwd=usbw;SSL Mode=None"; //definimos string de conexion
                con = new MySqlConnection(connectionString); //creamos la conexion
                con.Open(); //abrimos la conexio a la base de datos
                MetroFramework.MetroMessageBox.Show(this, "Se establecio conexión!", "TEST",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this, Ex.Message, "EXCEPCION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }
        }
    }
}
