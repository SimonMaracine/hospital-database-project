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
            // TODO: This line of code loads data into the '_hospital_database_data_set.Treatments' table. You can move, or remove it, as needed.
            this.treatmentsTableAdapter.Fill(this._hospital_database_data_set.Treatments);
            // TODO: This line of code loads data into the '_hospital_database_data_set.ViewWatchmenShifts' table. You can move, or remove it, as needed.
            this.viewWatchmenShiftsTableAdapter.Fill(this._hospital_database_data_set.ViewWatchmenShifts);
            // TODO: This line of code loads data into the '_hospital_database_data_set.ViewNursesShifts' table. You can move, or remove it, as needed.
            this.viewNursesShiftsTableAdapter.Fill(this._hospital_database_data_set.ViewNursesShifts);
            // TODO: This line of code loads data into the '_hospital_database_data_set.ViewDoctorsShifts' table. You can move, or remove it, as needed.
            this.viewDoctorsShiftsTableAdapter.Fill(this._hospital_database_data_set.ViewDoctorsShifts);
            // TODO: This line of code loads data into the '_hospital_database_data_set.Shifts' table. You can move, or remove it, as needed.
            this.shiftsTableAdapter.Fill(this._hospital_database_data_set.Shifts);
            // TODO: This line of code loads data into the '_hospital_database_data_set.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this._hospital_database_data_set.Rooms);
            // TODO: This line of code loads data into the '_hospital_database_data_set.Partners' table. You can move, or remove it, as needed.
            this.partnersTableAdapter.Fill(this._hospital_database_data_set.Partners);
            // TODO: This line of code loads data into the '_hospital_database_data_set.OperationTheaters' table. You can move, or remove it, as needed.
            this.operationTheatersTableAdapter.Fill(this._hospital_database_data_set.OperationTheaters);
            // TODO: This line of code loads data into the '_hospital_database_data_set.ICUs' table. You can move, or remove it, as needed.
            this.iCUsTableAdapter.Fill(this._hospital_database_data_set.ICUs);
            // TODO: This line of code loads data into the '_hospital_database_data_set.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this._hospital_database_data_set.Employees);
            // TODO: This line of code loads data into the '_hospital_database_data_set.DoctorsPartners' table. You can move, or remove it, as needed.
            this.doctorsPartnersTableAdapter.Fill(this._hospital_database_data_set.DoctorsPartners);
            // TODO: This line of code loads data into the '_hospital_database_data_set.TreatmentsMedicines' table. You can move, or remove it, as needed.
            this.treatmentsMedicinesTableAdapter.Fill(this._hospital_database_data_set.TreatmentsMedicines);
            // TODO: This line of code loads data into the '_hospital_database_data_set.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this._hospital_database_data_set.Medicines);
            // TODO: This line of code loads data into the '_hospital_database_data_set.Bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter.Fill(this._hospital_database_data_set.Bills);
            // TODO: This line of code loads data into the '_hospital_database_data_set.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this._hospital_database_data_set.Patients);
            // TODO: This line of code loads data into the '_hospital_database_data_set.Apprentices' table. You can move, or remove it, as needed.
            this.apprenticesTableAdapter.Fill(this._hospital_database_data_set.Apprentices);
            // TODO: This line of code loads data into the '_hospital_database_data_set.Watchmen' table. You can move, or remove it, as needed.
            this.watchmenTableAdapter.Fill(this._hospital_database_data_set.Watchmen);
            // TODO: This line of code loads data into the '_hospital_database_data_set.Nurses' table. You can move, or remove it, as needed.
            this.nursesTableAdapter.Fill(this._hospital_database_data_set.Nurses);
            // TODO: This line of code loads data into the '_hospital_database_data_set.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this._hospital_database_data_set.Doctors);

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
