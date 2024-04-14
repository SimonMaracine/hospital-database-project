using System;
using System.Windows.Forms;

namespace hospital_gui
{
    public partial class HospitalGUI : Form
    {
        public HospitalGUI()
        {
            InitializeComponent();
        }

        private void HospitalGUI_Load(object sender, EventArgs e)
        {
            this.viewMedicinesTableAdapter.Fill(this._hospital_database_data_set.ViewMedicines);
            this.treatmentsTableAdapter.Fill(this._hospital_database_data_set.Treatments);
            this.viewWatchmenShiftsTableAdapter.Fill(this._hospital_database_data_set.ViewWatchmenShifts);
            this.viewNursesShiftsTableAdapter.Fill(this._hospital_database_data_set.ViewNursesShifts);
            this.viewDoctorsShiftsTableAdapter.Fill(this._hospital_database_data_set.ViewDoctorsShifts);
            this.shiftsTableAdapter.Fill(this._hospital_database_data_set.Shifts);
            this.roomsTableAdapter.Fill(this._hospital_database_data_set.Rooms);
            this.partnersTableAdapter.Fill(this._hospital_database_data_set.Partners);
            this.operationTheatersTableAdapter.Fill(this._hospital_database_data_set.OperationTheaters);
            this.iCUsTableAdapter.Fill(this._hospital_database_data_set.ICUs);
            this.employeesTableAdapter.Fill(this._hospital_database_data_set.Employees);
            this.doctorsPartnersTableAdapter.Fill(this._hospital_database_data_set.DoctorsPartners);
            this.treatmentsMedicinesTableAdapter.Fill(this._hospital_database_data_set.TreatmentsMedicines);
            this.medicinesTableAdapter.Fill(this._hospital_database_data_set.Medicines);
            this.billsTableAdapter.Fill(this._hospital_database_data_set.Bills);
            this.patientsTableAdapter.Fill(this._hospital_database_data_set.Patients);
            this.apprenticesTableAdapter.Fill(this._hospital_database_data_set.Apprentices);
            this.watchmenTableAdapter.Fill(this._hospital_database_data_set.Watchmen);
            this.nursesTableAdapter.Fill(this._hospital_database_data_set.Nurses);
            this.doctorsTableAdapter.Fill(this._hospital_database_data_set.Doctors);
        }

        private void refreshMenuItem_Click(object sender, EventArgs e)
        {
            this.shiftsTableAdapter.Update(this._hospital_database_data_set.Shifts);
            this.roomsTableAdapter.Update(this._hospital_database_data_set.Rooms);
            this.partnersTableAdapter.Update(this._hospital_database_data_set.Partners);
            this.operationTheatersTableAdapter.Update(this._hospital_database_data_set.OperationTheaters);
            this.iCUsTableAdapter.Update(this._hospital_database_data_set.ICUs);
            this.employeesTableAdapter.Update(this._hospital_database_data_set.Employees);
            this.doctorsPartnersTableAdapter.Update(this._hospital_database_data_set.DoctorsPartners);
            this.treatmentsMedicinesTableAdapter.Update(this._hospital_database_data_set.TreatmentsMedicines);
            this.medicinesTableAdapter.Update(this._hospital_database_data_set.Medicines);
            this.billsTableAdapter.Update(this._hospital_database_data_set.Bills);
            this.patientsTableAdapter.Update(this._hospital_database_data_set.Patients);
            this.apprenticesTableAdapter.Update(this._hospital_database_data_set.Apprentices);
            this.watchmenTableAdapter.Update(this._hospital_database_data_set.Watchmen);
            this.nursesTableAdapter.Update(this._hospital_database_data_set.Nurses);
            this.doctorsTableAdapter.Update(this._hospital_database_data_set.Doctors);
        }
    }
}
