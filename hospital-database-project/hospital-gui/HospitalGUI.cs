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

namespace hospital_gui
{
    public partial class HospitalGUI : Form
    {
        private readonly string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=hospital-database;Integrated Security=True;Pooling=False;Connect Timeout=30";
        private SqlConnection connection;

        public HospitalGUI()
        {
            InitializeComponent();
        }

        private void HospitalGUI_Load(object sender, EventArgs e)
        {

        }

        private void connectMenuItem_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                MessageBox.Show("Already an existing connection");
                return;
            }

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Could not open connection: " + ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Could not open connection: " + ex.Message);
            }
        }

        private void disconnectMenuItem_Click(object sender, EventArgs e)
        {
            if (connection == null)
            {
                MessageBox.Show("No connection");
                return;
            }

            try
            {
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error closing connection: " + ex.Message);
            }

            connection = null;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                connection.Close();
            }

            Application.Exit();
        }
    }
}
