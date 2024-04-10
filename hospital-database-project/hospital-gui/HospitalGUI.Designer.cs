namespace hospital_gui
{
    partial class HospitalGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._hospital_database_data_set = new hospital_gui._hospital_database_data_set();
            this.hospitaldatabasedatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.DoctorsTableAdapter();
            this.tableAdapterManager = new hospital_gui._hospital_database_data_setTableAdapters.TableAdapterManager();
            this.apprenticesTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.ApprenticesTableAdapter();
            this.billsTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.BillsTableAdapter();
            this.medicinesTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.MedicinesTableAdapter();
            this.nursesTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.NursesTableAdapter();
            this.patientsTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.PatientsTableAdapter();
            this.treatmentsMedicinesTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.TreatmentsMedicinesTableAdapter();
            this.watchmenTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.WatchmenTableAdapter();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageApprentices = new System.Windows.Forms.TabPage();
            this.apprenticesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apprenticesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageBills = new System.Windows.Forms.TabPage();
            this.billsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDoctors = new System.Windows.Forms.TabPage();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageDoctorsPartners = new System.Windows.Forms.TabPage();
            this.doctorsPartnersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsPartnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageICUs = new System.Windows.Forms.TabPage();
            this.iCUsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCUsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageMedicines = new System.Windows.Forms.TabPage();
            this.medicinesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageNurses = new System.Windows.Forms.TabPage();
            this.nursesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageOperationTheaters = new System.Windows.Forms.TabPage();
            this.operationTheatersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationTheatersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPagePartners = new System.Windows.Forms.TabPage();
            this.partnersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPagePatients = new System.Windows.Forms.TabPage();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn76 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn77 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageShifts = new System.Windows.Forms.TabPage();
            this.shiftsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn78 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn81 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageTreatments = new System.Windows.Forms.TabPage();
            this.tabPageTreatmentsMedicines = new System.Windows.Forms.TabPage();
            this.treatmentsMedicinesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentsMedicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageViewDoctorShifts = new System.Windows.Forms.TabPage();
            this.viewDoctorsShiftsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn82 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn83 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn84 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewDoctorsShiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageViewNursesShifts = new System.Windows.Forms.TabPage();
            this.viewNursesShiftsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn85 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn86 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn87 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewNursesShiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageViewWatchmenShifts = new System.Windows.Forms.TabPage();
            this.viewWatchmenShiftsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn88 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn89 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewWatchmenShiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageWatchmen = new System.Windows.Forms.TabPage();
            this.watchmenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.watchmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsPartnersTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.DoctorsPartnersTableAdapter();
            this.employeesTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.EmployeesTableAdapter();
            this.iCUsTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.ICUsTableAdapter();
            this.operationTheatersTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.OperationTheatersTableAdapter();
            this.partnersTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.PartnersTableAdapter();
            this.roomsTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.RoomsTableAdapter();
            this.shiftsTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.ShiftsTableAdapter();
            this.viewDoctorsShiftsTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.ViewDoctorsShiftsTableAdapter();
            this.viewNursesShiftsTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.ViewNursesShiftsTableAdapter();
            this.viewWatchmenShiftsTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.ViewWatchmenShiftsTableAdapter();
            this.treatmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentsTableAdapter = new hospital_gui._hospital_database_data_setTableAdapters.TreatmentsTableAdapter();
            this.treatmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn91 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn92 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn93 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn94 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._hospital_database_data_set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldatabasedatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageApprentices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticesBindingSource)).BeginInit();
            this.tabPageBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            this.tabPageDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).BeginInit();
            this.tabPageDoctorsPartners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsPartnersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsPartnersBindingSource)).BeginInit();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.tabPageICUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iCUsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCUsBindingSource)).BeginInit();
            this.tabPageMedicines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            this.tabPageNurses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nursesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursesBindingSource)).BeginInit();
            this.tabPageOperationTheaters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationTheatersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationTheatersBindingSource)).BeginInit();
            this.tabPagePartners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partnersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            this.tabPagePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.tabPageRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.tabPageShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).BeginInit();
            this.tabPageTreatments.SuspendLayout();
            this.tabPageTreatmentsMedicines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsMedicinesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsMedicinesBindingSource)).BeginInit();
            this.tabPageViewDoctorShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDoctorsShiftsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDoctorsShiftsBindingSource)).BeginInit();
            this.tabPageViewNursesShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewNursesShiftsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNursesShiftsBindingSource)).BeginInit();
            this.tabPageViewWatchmenShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewWatchmenShiftsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewWatchmenShiftsBindingSource)).BeginInit();
            this.tabPageWatchmen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchmenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(880, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMenuItem,
            this.disconnectMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // connectMenuItem
            // 
            this.connectMenuItem.Name = "connectMenuItem";
            this.connectMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectMenuItem.Text = "Connect";
            this.connectMenuItem.Click += new System.EventHandler(this.connectMenuItem_Click);
            // 
            // disconnectMenuItem
            // 
            this.disconnectMenuItem.Name = "disconnectMenuItem";
            this.disconnectMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectMenuItem.Text = "Disconnect";
            this.disconnectMenuItem.Click += new System.EventHandler(this.disconnectMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // _hospital_database_data_set
            // 
            this._hospital_database_data_set.DataSetName = "_hospital_database_data_set";
            this._hospital_database_data_set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitaldatabasedatasetBindingSource
            // 
            this.hospitaldatabasedatasetBindingSource.DataSource = this._hospital_database_data_set;
            this.hospitaldatabasedatasetBindingSource.Position = 0;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApprenticesTableAdapter = this.apprenticesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillsTableAdapter = this.billsTableAdapter;
            this.tableAdapterManager.DoctorsPartnersTableAdapter = null;
            this.tableAdapterManager.DoctorsTableAdapter = this.doctorsTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.ICUsTableAdapter = null;
            this.tableAdapterManager.MedicinesTableAdapter = this.medicinesTableAdapter;
            this.tableAdapterManager.NursesTableAdapter = this.nursesTableAdapter;
            this.tableAdapterManager.OperationTheatersTableAdapter = null;
            this.tableAdapterManager.PartnersTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.ShiftsTableAdapter = null;
            this.tableAdapterManager.TreatmentsMedicinesTableAdapter = this.treatmentsMedicinesTableAdapter;
            this.tableAdapterManager.TreatmentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = hospital_gui._hospital_database_data_setTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WatchmenTableAdapter = this.watchmenTableAdapter;
            // 
            // apprenticesTableAdapter
            // 
            this.apprenticesTableAdapter.ClearBeforeFill = true;
            // 
            // billsTableAdapter
            // 
            this.billsTableAdapter.ClearBeforeFill = true;
            // 
            // medicinesTableAdapter
            // 
            this.medicinesTableAdapter.ClearBeforeFill = true;
            // 
            // nursesTableAdapter
            // 
            this.nursesTableAdapter.ClearBeforeFill = true;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // treatmentsMedicinesTableAdapter
            // 
            this.treatmentsMedicinesTableAdapter.ClearBeforeFill = true;
            // 
            // watchmenTableAdapter
            // 
            this.watchmenTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageApprentices);
            this.tabControl.Controls.Add(this.tabPageBills);
            this.tabControl.Controls.Add(this.tabPageDoctors);
            this.tabControl.Controls.Add(this.tabPageDoctorsPartners);
            this.tabControl.Controls.Add(this.tabPageEmployees);
            this.tabControl.Controls.Add(this.tabPageICUs);
            this.tabControl.Controls.Add(this.tabPageMedicines);
            this.tabControl.Controls.Add(this.tabPageNurses);
            this.tabControl.Controls.Add(this.tabPageOperationTheaters);
            this.tabControl.Controls.Add(this.tabPagePartners);
            this.tabControl.Controls.Add(this.tabPagePatients);
            this.tabControl.Controls.Add(this.tabPageRooms);
            this.tabControl.Controls.Add(this.tabPageShifts);
            this.tabControl.Controls.Add(this.tabPageTreatments);
            this.tabControl.Controls.Add(this.tabPageTreatmentsMedicines);
            this.tabControl.Controls.Add(this.tabPageViewDoctorShifts);
            this.tabControl.Controls.Add(this.tabPageViewNursesShifts);
            this.tabControl.Controls.Add(this.tabPageViewWatchmenShifts);
            this.tabControl.Controls.Add(this.tabPageWatchmen);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(880, 441);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageApprentices
            // 
            this.tabPageApprentices.Controls.Add(this.apprenticesDataGridView);
            this.tabPageApprentices.Location = new System.Drawing.Point(4, 22);
            this.tabPageApprentices.Name = "tabPageApprentices";
            this.tabPageApprentices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApprentices.Size = new System.Drawing.Size(792, 400);
            this.tabPageApprentices.TabIndex = 3;
            this.tabPageApprentices.Text = "Apprentices";
            this.tabPageApprentices.UseVisualStyleBackColor = true;
            // 
            // apprenticesDataGridView
            // 
            this.apprenticesDataGridView.AutoGenerateColumns = false;
            this.apprenticesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apprenticesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33});
            this.apprenticesDataGridView.DataSource = this.apprenticesBindingSource;
            this.apprenticesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apprenticesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.apprenticesDataGridView.Name = "apprenticesDataGridView";
            this.apprenticesDataGridView.Size = new System.Drawing.Size(786, 394);
            this.apprenticesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn25.HeaderText = "id";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn26.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn27.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn28.HeaderText = "age";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn29.HeaderText = "gender";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "university";
            this.dataGridViewTextBoxColumn30.HeaderText = "university";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "study_year";
            this.dataGridViewTextBoxColumn31.HeaderText = "study_year";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "specialization";
            this.dataGridViewTextBoxColumn32.HeaderText = "specialization";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "doctor_id";
            this.dataGridViewTextBoxColumn33.HeaderText = "doctor_id";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // apprenticesBindingSource
            // 
            this.apprenticesBindingSource.DataMember = "Apprentices";
            this.apprenticesBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageBills
            // 
            this.tabPageBills.Controls.Add(this.billsDataGridView);
            this.tabPageBills.Location = new System.Drawing.Point(4, 22);
            this.tabPageBills.Name = "tabPageBills";
            this.tabPageBills.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBills.Size = new System.Drawing.Size(792, 400);
            this.tabPageBills.TabIndex = 5;
            this.tabPageBills.Text = "Bills";
            this.tabPageBills.UseVisualStyleBackColor = true;
            // 
            // billsDataGridView
            // 
            this.billsDataGridView.AutoGenerateColumns = false;
            this.billsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48});
            this.billsDataGridView.DataSource = this.billsBindingSource;
            this.billsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.billsDataGridView.Name = "billsDataGridView";
            this.billsDataGridView.Size = new System.Drawing.Size(786, 394);
            this.billsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn44.HeaderText = "id";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn45.HeaderText = "name";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "sum";
            this.dataGridViewTextBoxColumn46.HeaderText = "sum";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn47.HeaderText = "state";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "patient_id";
            this.dataGridViewTextBoxColumn48.HeaderText = "patient_id";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataMember = "Bills";
            this.billsBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageDoctors
            // 
            this.tabPageDoctors.Controls.Add(this.doctorsDataGridView);
            this.tabPageDoctors.Location = new System.Drawing.Point(4, 22);
            this.tabPageDoctors.Name = "tabPageDoctors";
            this.tabPageDoctors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoctors.Size = new System.Drawing.Size(792, 400);
            this.tabPageDoctors.TabIndex = 0;
            this.tabPageDoctors.Text = "Doctors";
            this.tabPageDoctors.UseVisualStyleBackColor = true;
            // 
            // doctorsDataGridView
            // 
            this.doctorsDataGridView.AutoGenerateColumns = false;
            this.doctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.doctorsDataGridView.DataSource = this.doctorsBindingSource;
            this.doctorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.Size = new System.Drawing.Size(786, 394);
            this.doctorsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn4.HeaderText = "age";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn5.HeaderText = "gender";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "studies";
            this.dataGridViewTextBoxColumn6.HeaderText = "studies";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "specialization";
            this.dataGridViewTextBoxColumn7.HeaderText = "specialization";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "partner_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "partner_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "employee_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "employee_id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // tabPageDoctorsPartners
            // 
            this.tabPageDoctorsPartners.Controls.Add(this.doctorsPartnersDataGridView);
            this.tabPageDoctorsPartners.Location = new System.Drawing.Point(4, 22);
            this.tabPageDoctorsPartners.Name = "tabPageDoctorsPartners";
            this.tabPageDoctorsPartners.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoctorsPartners.Size = new System.Drawing.Size(792, 400);
            this.tabPageDoctorsPartners.TabIndex = 9;
            this.tabPageDoctorsPartners.Text = "DoctorsPartners";
            this.tabPageDoctorsPartners.UseVisualStyleBackColor = true;
            // 
            // doctorsPartnersDataGridView
            // 
            this.doctorsPartnersDataGridView.AutoGenerateColumns = false;
            this.doctorsPartnersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsPartnersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58});
            this.doctorsPartnersDataGridView.DataSource = this.doctorsPartnersBindingSource;
            this.doctorsPartnersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorsPartnersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.doctorsPartnersDataGridView.Name = "doctorsPartnersDataGridView";
            this.doctorsPartnersDataGridView.Size = new System.Drawing.Size(786, 394);
            this.doctorsPartnersDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "doctor_id";
            this.dataGridViewTextBoxColumn57.HeaderText = "doctor_id";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "partner_id";
            this.dataGridViewTextBoxColumn58.HeaderText = "partner_id";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            // 
            // doctorsPartnersBindingSource
            // 
            this.doctorsPartnersBindingSource.DataMember = "DoctorsPartners";
            this.doctorsPartnersBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.AutoScroll = true;
            this.tabPageEmployees.Controls.Add(this.employeesDataGridView);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees.Size = new System.Drawing.Size(792, 400);
            this.tabPageEmployees.TabIndex = 10;
            this.tabPageEmployees.Text = "Employees";
            this.tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60,
            this.dataGridViewTextBoxColumn61});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(786, 394);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn59.HeaderText = "id";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn60.HeaderText = "type";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "shift_id";
            this.dataGridViewTextBoxColumn61.HeaderText = "shift_id";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageICUs
            // 
            this.tabPageICUs.AutoScroll = true;
            this.tabPageICUs.Controls.Add(this.iCUsDataGridView);
            this.tabPageICUs.Location = new System.Drawing.Point(4, 22);
            this.tabPageICUs.Name = "tabPageICUs";
            this.tabPageICUs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageICUs.Size = new System.Drawing.Size(792, 400);
            this.tabPageICUs.TabIndex = 11;
            this.tabPageICUs.Text = "ICUs";
            this.tabPageICUs.UseVisualStyleBackColor = true;
            // 
            // iCUsDataGridView
            // 
            this.iCUsDataGridView.AutoGenerateColumns = false;
            this.iCUsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iCUsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65});
            this.iCUsDataGridView.DataSource = this.iCUsBindingSource;
            this.iCUsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iCUsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.iCUsDataGridView.Name = "iCUsDataGridView";
            this.iCUsDataGridView.Size = new System.Drawing.Size(786, 394);
            this.iCUsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn62.HeaderText = "number";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "floor";
            this.dataGridViewTextBoxColumn63.HeaderText = "floor";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn64.HeaderText = "type";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "room_id";
            this.dataGridViewTextBoxColumn65.HeaderText = "room_id";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            // 
            // iCUsBindingSource
            // 
            this.iCUsBindingSource.DataMember = "ICUs";
            this.iCUsBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageMedicines
            // 
            this.tabPageMedicines.Controls.Add(this.medicinesDataGridView);
            this.tabPageMedicines.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedicines.Name = "tabPageMedicines";
            this.tabPageMedicines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedicines.Size = new System.Drawing.Size(792, 400);
            this.tabPageMedicines.TabIndex = 6;
            this.tabPageMedicines.Text = "Medicines";
            this.tabPageMedicines.UseVisualStyleBackColor = true;
            // 
            // medicinesDataGridView
            // 
            this.medicinesDataGridView.AutoGenerateColumns = false;
            this.medicinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52});
            this.medicinesDataGridView.DataSource = this.medicinesBindingSource;
            this.medicinesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicinesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.medicinesDataGridView.Name = "medicinesDataGridView";
            this.medicinesDataGridView.Size = new System.Drawing.Size(786, 394);
            this.medicinesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn49.HeaderText = "id";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn50.HeaderText = "name";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "expiration_date";
            this.dataGridViewTextBoxColumn51.HeaderText = "expiration_date";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "provider";
            this.dataGridViewTextBoxColumn52.HeaderText = "provider";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            // 
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataMember = "Medicines";
            this.medicinesBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageNurses
            // 
            this.tabPageNurses.Controls.Add(this.nursesDataGridView);
            this.tabPageNurses.Location = new System.Drawing.Point(4, 22);
            this.tabPageNurses.Name = "tabPageNurses";
            this.tabPageNurses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNurses.Size = new System.Drawing.Size(792, 400);
            this.tabPageNurses.TabIndex = 1;
            this.tabPageNurses.Text = "Nurses";
            this.tabPageNurses.UseVisualStyleBackColor = true;
            // 
            // nursesDataGridView
            // 
            this.nursesDataGridView.AutoGenerateColumns = false;
            this.nursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.nursesDataGridView.DataSource = this.nursesBindingSource;
            this.nursesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nursesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.nursesDataGridView.Name = "nursesDataGridView";
            this.nursesDataGridView.Size = new System.Drawing.Size(786, 394);
            this.nursesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn10.HeaderText = "id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn11.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn12.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn13.HeaderText = "age";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn14.HeaderText = "gender";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "studies";
            this.dataGridViewTextBoxColumn15.HeaderText = "studies";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "floor";
            this.dataGridViewTextBoxColumn16.HeaderText = "floor";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "employee_id";
            this.dataGridViewTextBoxColumn17.HeaderText = "employee_id";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // nursesBindingSource
            // 
            this.nursesBindingSource.DataMember = "Nurses";
            this.nursesBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageOperationTheaters
            // 
            this.tabPageOperationTheaters.Controls.Add(this.operationTheatersDataGridView);
            this.tabPageOperationTheaters.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperationTheaters.Name = "tabPageOperationTheaters";
            this.tabPageOperationTheaters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperationTheaters.Size = new System.Drawing.Size(792, 400);
            this.tabPageOperationTheaters.TabIndex = 12;
            this.tabPageOperationTheaters.Text = "OperationTheaters";
            this.tabPageOperationTheaters.UseVisualStyleBackColor = true;
            // 
            // operationTheatersDataGridView
            // 
            this.operationTheatersDataGridView.AutoGenerateColumns = false;
            this.operationTheatersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationTheatersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn66,
            this.dataGridViewTextBoxColumn67,
            this.dataGridViewTextBoxColumn68,
            this.dataGridViewTextBoxColumn69});
            this.operationTheatersDataGridView.DataSource = this.operationTheatersBindingSource;
            this.operationTheatersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationTheatersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.operationTheatersDataGridView.Name = "operationTheatersDataGridView";
            this.operationTheatersDataGridView.Size = new System.Drawing.Size(786, 394);
            this.operationTheatersDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn66.HeaderText = "number";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "floor";
            this.dataGridViewTextBoxColumn67.HeaderText = "floor";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "specialization";
            this.dataGridViewTextBoxColumn68.HeaderText = "specialization";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "room_id";
            this.dataGridViewTextBoxColumn69.HeaderText = "room_id";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            // 
            // operationTheatersBindingSource
            // 
            this.operationTheatersBindingSource.DataMember = "OperationTheaters";
            this.operationTheatersBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPagePartners
            // 
            this.tabPagePartners.Controls.Add(this.partnersDataGridView);
            this.tabPagePartners.Location = new System.Drawing.Point(4, 22);
            this.tabPagePartners.Name = "tabPagePartners";
            this.tabPagePartners.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePartners.Size = new System.Drawing.Size(792, 400);
            this.tabPagePartners.TabIndex = 13;
            this.tabPagePartners.Text = "Partners";
            this.tabPagePartners.UseVisualStyleBackColor = true;
            // 
            // partnersDataGridView
            // 
            this.partnersDataGridView.AutoGenerateColumns = false;
            this.partnersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partnersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn70,
            this.dataGridViewTextBoxColumn71,
            this.dataGridViewTextBoxColumn72,
            this.dataGridViewTextBoxColumn73,
            this.dataGridViewTextBoxColumn74,
            this.dataGridViewTextBoxColumn75});
            this.partnersDataGridView.DataSource = this.partnersBindingSource;
            this.partnersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partnersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.partnersDataGridView.Name = "partnersDataGridView";
            this.partnersDataGridView.Size = new System.Drawing.Size(786, 394);
            this.partnersDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn70.HeaderText = "id";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn70.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn71.HeaderText = "name";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.DataPropertyName = "partnership_type";
            this.dataGridViewTextBoxColumn72.HeaderText = "partnership_type";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.DataPropertyName = "begin_date";
            this.dataGridViewTextBoxColumn73.HeaderText = "begin_date";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.DataPropertyName = "end_date";
            this.dataGridViewTextBoxColumn74.HeaderText = "end_date";
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            // 
            // dataGridViewTextBoxColumn75
            // 
            this.dataGridViewTextBoxColumn75.DataPropertyName = "doctor_id";
            this.dataGridViewTextBoxColumn75.HeaderText = "doctor_id";
            this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataMember = "Partners";
            this.partnersBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPagePatients
            // 
            this.tabPagePatients.Controls.Add(this.patientsDataGridView);
            this.tabPagePatients.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatients.Name = "tabPagePatients";
            this.tabPagePatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatients.Size = new System.Drawing.Size(792, 400);
            this.tabPagePatients.TabIndex = 4;
            this.tabPagePatients.Text = "Patients";
            this.tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.AutoGenerateColumns = false;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43});
            this.patientsDataGridView.DataSource = this.patientsBindingSource;
            this.patientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.Size = new System.Drawing.Size(786, 394);
            this.patientsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn34.HeaderText = "id";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn35.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn36.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn37.HeaderText = "age";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn38.HeaderText = "gender";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "weight";
            this.dataGridViewTextBoxColumn39.HeaderText = "weight";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "occupation";
            this.dataGridViewTextBoxColumn40.HeaderText = "occupation";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "doctor_id";
            this.dataGridViewTextBoxColumn41.HeaderText = "doctor_id";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "treatment_id";
            this.dataGridViewTextBoxColumn42.HeaderText = "treatment_id";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "room_id";
            this.dataGridViewTextBoxColumn43.HeaderText = "room_id";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.roomsDataGridView);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 22);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRooms.Size = new System.Drawing.Size(792, 400);
            this.tabPageRooms.TabIndex = 14;
            this.tabPageRooms.Text = "Rooms";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.AutoGenerateColumns = false;
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn76,
            this.dataGridViewTextBoxColumn77});
            this.roomsDataGridView.DataSource = this.roomsBindingSource;
            this.roomsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.Size = new System.Drawing.Size(786, 394);
            this.roomsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn76
            // 
            this.dataGridViewTextBoxColumn76.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn76.HeaderText = "id";
            this.dataGridViewTextBoxColumn76.Name = "dataGridViewTextBoxColumn76";
            this.dataGridViewTextBoxColumn76.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn77
            // 
            this.dataGridViewTextBoxColumn77.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn77.HeaderText = "type";
            this.dataGridViewTextBoxColumn77.Name = "dataGridViewTextBoxColumn77";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageShifts
            // 
            this.tabPageShifts.Controls.Add(this.shiftsDataGridView);
            this.tabPageShifts.Location = new System.Drawing.Point(4, 22);
            this.tabPageShifts.Name = "tabPageShifts";
            this.tabPageShifts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShifts.Size = new System.Drawing.Size(792, 400);
            this.tabPageShifts.TabIndex = 15;
            this.tabPageShifts.Text = "Shifts";
            this.tabPageShifts.UseVisualStyleBackColor = true;
            // 
            // shiftsDataGridView
            // 
            this.shiftsDataGridView.AutoGenerateColumns = false;
            this.shiftsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn78,
            this.dataGridViewTextBoxColumn79,
            this.dataGridViewTextBoxColumn80,
            this.dataGridViewTextBoxColumn81});
            this.shiftsDataGridView.DataSource = this.shiftsBindingSource;
            this.shiftsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shiftsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.shiftsDataGridView.Name = "shiftsDataGridView";
            this.shiftsDataGridView.Size = new System.Drawing.Size(786, 394);
            this.shiftsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn78
            // 
            this.dataGridViewTextBoxColumn78.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn78.HeaderText = "id";
            this.dataGridViewTextBoxColumn78.Name = "dataGridViewTextBoxColumn78";
            this.dataGridViewTextBoxColumn78.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.DataPropertyName = "begin_time";
            this.dataGridViewTextBoxColumn79.HeaderText = "begin_time";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.DataPropertyName = "end_time";
            this.dataGridViewTextBoxColumn80.HeaderText = "end_time";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            // 
            // dataGridViewTextBoxColumn81
            // 
            this.dataGridViewTextBoxColumn81.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn81.HeaderText = "description";
            this.dataGridViewTextBoxColumn81.Name = "dataGridViewTextBoxColumn81";
            // 
            // shiftsBindingSource
            // 
            this.shiftsBindingSource.DataMember = "Shifts";
            this.shiftsBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageTreatments
            // 
            this.tabPageTreatments.Controls.Add(this.treatmentsDataGridView);
            this.tabPageTreatments.Location = new System.Drawing.Point(4, 22);
            this.tabPageTreatments.Name = "tabPageTreatments";
            this.tabPageTreatments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTreatments.Size = new System.Drawing.Size(872, 415);
            this.tabPageTreatments.TabIndex = 7;
            this.tabPageTreatments.Text = "Treatments";
            this.tabPageTreatments.UseVisualStyleBackColor = true;
            // 
            // tabPageTreatmentsMedicines
            // 
            this.tabPageTreatmentsMedicines.AutoScroll = true;
            this.tabPageTreatmentsMedicines.Controls.Add(this.treatmentsMedicinesDataGridView);
            this.tabPageTreatmentsMedicines.Location = new System.Drawing.Point(4, 22);
            this.tabPageTreatmentsMedicines.Name = "tabPageTreatmentsMedicines";
            this.tabPageTreatmentsMedicines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTreatmentsMedicines.Size = new System.Drawing.Size(792, 400);
            this.tabPageTreatmentsMedicines.TabIndex = 8;
            this.tabPageTreatmentsMedicines.Text = "TreatmentsMedicines";
            this.tabPageTreatmentsMedicines.UseVisualStyleBackColor = true;
            // 
            // treatmentsMedicinesDataGridView
            // 
            this.treatmentsMedicinesDataGridView.AutoGenerateColumns = false;
            this.treatmentsMedicinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatmentsMedicinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56});
            this.treatmentsMedicinesDataGridView.DataSource = this.treatmentsMedicinesBindingSource;
            this.treatmentsMedicinesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treatmentsMedicinesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.treatmentsMedicinesDataGridView.Name = "treatmentsMedicinesDataGridView";
            this.treatmentsMedicinesDataGridView.Size = new System.Drawing.Size(786, 394);
            this.treatmentsMedicinesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "treatment_id";
            this.dataGridViewTextBoxColumn53.HeaderText = "treatment_id";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "medicine_id";
            this.dataGridViewTextBoxColumn54.HeaderText = "medicine_id";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "medicine_dosage";
            this.dataGridViewTextBoxColumn55.HeaderText = "medicine_dosage";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn56.HeaderText = "description";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            // 
            // treatmentsMedicinesBindingSource
            // 
            this.treatmentsMedicinesBindingSource.DataMember = "TreatmentsMedicines";
            this.treatmentsMedicinesBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageViewDoctorShifts
            // 
            this.tabPageViewDoctorShifts.Controls.Add(this.viewDoctorsShiftsDataGridView);
            this.tabPageViewDoctorShifts.Location = new System.Drawing.Point(4, 22);
            this.tabPageViewDoctorShifts.Name = "tabPageViewDoctorShifts";
            this.tabPageViewDoctorShifts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewDoctorShifts.Size = new System.Drawing.Size(792, 400);
            this.tabPageViewDoctorShifts.TabIndex = 16;
            this.tabPageViewDoctorShifts.Text = "ViewDoctorShifts";
            this.tabPageViewDoctorShifts.UseVisualStyleBackColor = true;
            // 
            // viewDoctorsShiftsDataGridView
            // 
            this.viewDoctorsShiftsDataGridView.AutoGenerateColumns = false;
            this.viewDoctorsShiftsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDoctorsShiftsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn82,
            this.dataGridViewTextBoxColumn83,
            this.dataGridViewTextBoxColumn84});
            this.viewDoctorsShiftsDataGridView.DataSource = this.viewDoctorsShiftsBindingSource;
            this.viewDoctorsShiftsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewDoctorsShiftsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.viewDoctorsShiftsDataGridView.Name = "viewDoctorsShiftsDataGridView";
            this.viewDoctorsShiftsDataGridView.Size = new System.Drawing.Size(786, 394);
            this.viewDoctorsShiftsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn82
            // 
            this.dataGridViewTextBoxColumn82.DataPropertyName = "DoctorID";
            this.dataGridViewTextBoxColumn82.HeaderText = "DoctorID";
            this.dataGridViewTextBoxColumn82.Name = "dataGridViewTextBoxColumn82";
            // 
            // dataGridViewTextBoxColumn83
            // 
            this.dataGridViewTextBoxColumn83.DataPropertyName = "DoctorName";
            this.dataGridViewTextBoxColumn83.HeaderText = "DoctorName";
            this.dataGridViewTextBoxColumn83.Name = "dataGridViewTextBoxColumn83";
            this.dataGridViewTextBoxColumn83.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn84
            // 
            this.dataGridViewTextBoxColumn84.DataPropertyName = "ShiftDescription";
            this.dataGridViewTextBoxColumn84.HeaderText = "ShiftDescription";
            this.dataGridViewTextBoxColumn84.Name = "dataGridViewTextBoxColumn84";
            // 
            // viewDoctorsShiftsBindingSource
            // 
            this.viewDoctorsShiftsBindingSource.DataMember = "ViewDoctorsShifts";
            this.viewDoctorsShiftsBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageViewNursesShifts
            // 
            this.tabPageViewNursesShifts.Controls.Add(this.viewNursesShiftsDataGridView);
            this.tabPageViewNursesShifts.Location = new System.Drawing.Point(4, 22);
            this.tabPageViewNursesShifts.Name = "tabPageViewNursesShifts";
            this.tabPageViewNursesShifts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewNursesShifts.Size = new System.Drawing.Size(792, 400);
            this.tabPageViewNursesShifts.TabIndex = 17;
            this.tabPageViewNursesShifts.Text = "ViewNursesShifts";
            this.tabPageViewNursesShifts.UseVisualStyleBackColor = true;
            // 
            // viewNursesShiftsDataGridView
            // 
            this.viewNursesShiftsDataGridView.AutoGenerateColumns = false;
            this.viewNursesShiftsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewNursesShiftsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn85,
            this.dataGridViewTextBoxColumn86,
            this.dataGridViewTextBoxColumn87});
            this.viewNursesShiftsDataGridView.DataSource = this.viewNursesShiftsBindingSource;
            this.viewNursesShiftsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewNursesShiftsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.viewNursesShiftsDataGridView.Name = "viewNursesShiftsDataGridView";
            this.viewNursesShiftsDataGridView.Size = new System.Drawing.Size(786, 394);
            this.viewNursesShiftsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn85
            // 
            this.dataGridViewTextBoxColumn85.DataPropertyName = "NurseID";
            this.dataGridViewTextBoxColumn85.HeaderText = "NurseID";
            this.dataGridViewTextBoxColumn85.Name = "dataGridViewTextBoxColumn85";
            // 
            // dataGridViewTextBoxColumn86
            // 
            this.dataGridViewTextBoxColumn86.DataPropertyName = "NurseName";
            this.dataGridViewTextBoxColumn86.HeaderText = "NurseName";
            this.dataGridViewTextBoxColumn86.Name = "dataGridViewTextBoxColumn86";
            this.dataGridViewTextBoxColumn86.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn87
            // 
            this.dataGridViewTextBoxColumn87.DataPropertyName = "ShiftDescription";
            this.dataGridViewTextBoxColumn87.HeaderText = "ShiftDescription";
            this.dataGridViewTextBoxColumn87.Name = "dataGridViewTextBoxColumn87";
            // 
            // viewNursesShiftsBindingSource
            // 
            this.viewNursesShiftsBindingSource.DataMember = "ViewNursesShifts";
            this.viewNursesShiftsBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageViewWatchmenShifts
            // 
            this.tabPageViewWatchmenShifts.AutoScroll = true;
            this.tabPageViewWatchmenShifts.Controls.Add(this.viewWatchmenShiftsDataGridView);
            this.tabPageViewWatchmenShifts.Location = new System.Drawing.Point(4, 22);
            this.tabPageViewWatchmenShifts.Name = "tabPageViewWatchmenShifts";
            this.tabPageViewWatchmenShifts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewWatchmenShifts.Size = new System.Drawing.Size(792, 400);
            this.tabPageViewWatchmenShifts.TabIndex = 18;
            this.tabPageViewWatchmenShifts.Text = "ViewWatchmenShifts";
            this.tabPageViewWatchmenShifts.UseVisualStyleBackColor = true;
            // 
            // viewWatchmenShiftsDataGridView
            // 
            this.viewWatchmenShiftsDataGridView.AutoGenerateColumns = false;
            this.viewWatchmenShiftsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewWatchmenShiftsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn88,
            this.dataGridViewTextBoxColumn89,
            this.dataGridViewTextBoxColumn90});
            this.viewWatchmenShiftsDataGridView.DataSource = this.viewWatchmenShiftsBindingSource;
            this.viewWatchmenShiftsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewWatchmenShiftsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.viewWatchmenShiftsDataGridView.Name = "viewWatchmenShiftsDataGridView";
            this.viewWatchmenShiftsDataGridView.Size = new System.Drawing.Size(786, 394);
            this.viewWatchmenShiftsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn88
            // 
            this.dataGridViewTextBoxColumn88.DataPropertyName = "WatchmanID";
            this.dataGridViewTextBoxColumn88.HeaderText = "WatchmanID";
            this.dataGridViewTextBoxColumn88.Name = "dataGridViewTextBoxColumn88";
            // 
            // dataGridViewTextBoxColumn89
            // 
            this.dataGridViewTextBoxColumn89.DataPropertyName = "WatchmanName";
            this.dataGridViewTextBoxColumn89.HeaderText = "WatchmanName";
            this.dataGridViewTextBoxColumn89.Name = "dataGridViewTextBoxColumn89";
            this.dataGridViewTextBoxColumn89.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn90
            // 
            this.dataGridViewTextBoxColumn90.DataPropertyName = "ShiftDescription";
            this.dataGridViewTextBoxColumn90.HeaderText = "ShiftDescription";
            this.dataGridViewTextBoxColumn90.Name = "dataGridViewTextBoxColumn90";
            // 
            // viewWatchmenShiftsBindingSource
            // 
            this.viewWatchmenShiftsBindingSource.DataMember = "ViewWatchmenShifts";
            this.viewWatchmenShiftsBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // tabPageWatchmen
            // 
            this.tabPageWatchmen.Controls.Add(this.watchmenDataGridView);
            this.tabPageWatchmen.Location = new System.Drawing.Point(4, 22);
            this.tabPageWatchmen.Name = "tabPageWatchmen";
            this.tabPageWatchmen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWatchmen.Size = new System.Drawing.Size(792, 400);
            this.tabPageWatchmen.TabIndex = 2;
            this.tabPageWatchmen.Text = "Watchmen";
            this.tabPageWatchmen.UseVisualStyleBackColor = true;
            // 
            // watchmenDataGridView
            // 
            this.watchmenDataGridView.AutoGenerateColumns = false;
            this.watchmenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watchmenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.watchmenDataGridView.DataSource = this.watchmenBindingSource;
            this.watchmenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchmenDataGridView.Location = new System.Drawing.Point(3, 3);
            this.watchmenDataGridView.Name = "watchmenDataGridView";
            this.watchmenDataGridView.Size = new System.Drawing.Size(786, 394);
            this.watchmenDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn18.HeaderText = "id";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn19.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn20.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn21.HeaderText = "age";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn22.HeaderText = "gender";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "assigned_zone";
            this.dataGridViewTextBoxColumn23.HeaderText = "assigned_zone";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "employee_id";
            this.dataGridViewTextBoxColumn24.HeaderText = "employee_id";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // watchmenBindingSource
            // 
            this.watchmenBindingSource.DataMember = "Watchmen";
            this.watchmenBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // doctorsPartnersTableAdapter
            // 
            this.doctorsPartnersTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // iCUsTableAdapter
            // 
            this.iCUsTableAdapter.ClearBeforeFill = true;
            // 
            // operationTheatersTableAdapter
            // 
            this.operationTheatersTableAdapter.ClearBeforeFill = true;
            // 
            // partnersTableAdapter
            // 
            this.partnersTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // shiftsTableAdapter
            // 
            this.shiftsTableAdapter.ClearBeforeFill = true;
            // 
            // viewDoctorsShiftsTableAdapter
            // 
            this.viewDoctorsShiftsTableAdapter.ClearBeforeFill = true;
            // 
            // viewNursesShiftsTableAdapter
            // 
            this.viewNursesShiftsTableAdapter.ClearBeforeFill = true;
            // 
            // viewWatchmenShiftsTableAdapter
            // 
            this.viewWatchmenShiftsTableAdapter.ClearBeforeFill = true;
            // 
            // treatmentsBindingSource
            // 
            this.treatmentsBindingSource.DataMember = "Treatments";
            this.treatmentsBindingSource.DataSource = this._hospital_database_data_set;
            // 
            // treatmentsTableAdapter
            // 
            this.treatmentsTableAdapter.ClearBeforeFill = true;
            // 
            // treatmentsDataGridView
            // 
            this.treatmentsDataGridView.AutoGenerateColumns = false;
            this.treatmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn91,
            this.dataGridViewTextBoxColumn92,
            this.dataGridViewTextBoxColumn93,
            this.dataGridViewTextBoxColumn94});
            this.treatmentsDataGridView.DataSource = this.treatmentsBindingSource;
            this.treatmentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treatmentsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.treatmentsDataGridView.Name = "treatmentsDataGridView";
            this.treatmentsDataGridView.Size = new System.Drawing.Size(866, 409);
            this.treatmentsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn91
            // 
            this.dataGridViewTextBoxColumn91.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn91.HeaderText = "id";
            this.dataGridViewTextBoxColumn91.Name = "dataGridViewTextBoxColumn91";
            this.dataGridViewTextBoxColumn91.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn92
            // 
            this.dataGridViewTextBoxColumn92.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn92.HeaderText = "name";
            this.dataGridViewTextBoxColumn92.Name = "dataGridViewTextBoxColumn92";
            // 
            // dataGridViewTextBoxColumn93
            // 
            this.dataGridViewTextBoxColumn93.DataPropertyName = "duration";
            this.dataGridViewTextBoxColumn93.HeaderText = "duration";
            this.dataGridViewTextBoxColumn93.Name = "dataGridViewTextBoxColumn93";
            // 
            // dataGridViewTextBoxColumn94
            // 
            this.dataGridViewTextBoxColumn94.DataPropertyName = "medicine_id";
            this.dataGridViewTextBoxColumn94.HeaderText = "medicine_id";
            this.dataGridViewTextBoxColumn94.Name = "dataGridViewTextBoxColumn94";
            // 
            // HospitalGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "HospitalGUI";
            this.Text = "Hospital GUI";
            this.Load += new System.EventHandler(this.HospitalGUI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._hospital_database_data_set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldatabasedatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageApprentices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apprenticesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticesBindingSource)).EndInit();
            this.tabPageBills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            this.tabPageDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).EndInit();
            this.tabPageDoctorsPartners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsPartnersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsPartnersBindingSource)).EndInit();
            this.tabPageEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.tabPageICUs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iCUsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCUsBindingSource)).EndInit();
            this.tabPageMedicines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            this.tabPageNurses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nursesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursesBindingSource)).EndInit();
            this.tabPageOperationTheaters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operationTheatersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationTheatersBindingSource)).EndInit();
            this.tabPagePartners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partnersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            this.tabPagePatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.tabPageRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.tabPageShifts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shiftsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).EndInit();
            this.tabPageTreatments.ResumeLayout(false);
            this.tabPageTreatmentsMedicines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsMedicinesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsMedicinesBindingSource)).EndInit();
            this.tabPageViewDoctorShifts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewDoctorsShiftsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDoctorsShiftsBindingSource)).EndInit();
            this.tabPageViewNursesShifts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewNursesShiftsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNursesShiftsBindingSource)).EndInit();
            this.tabPageViewWatchmenShifts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewWatchmenShiftsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewWatchmenShiftsBindingSource)).EndInit();
            this.tabPageWatchmen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watchmenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.BindingSource hospitaldatabasedatasetBindingSource;
        private _hospital_database_data_set _hospital_database_data_set;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private _hospital_database_data_setTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private _hospital_database_data_setTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDoctors;
        private System.Windows.Forms.TabPage tabPageNurses;
        private System.Windows.Forms.DataGridView doctorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private _hospital_database_data_setTableAdapters.NursesTableAdapter nursesTableAdapter;
        private System.Windows.Forms.BindingSource nursesBindingSource;
        private System.Windows.Forms.DataGridView nursesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.TabPage tabPageWatchmen;
        private System.Windows.Forms.TabPage tabPageApprentices;
        private System.Windows.Forms.TabPage tabPagePatients;
        private System.Windows.Forms.TabPage tabPageBills;
        private System.Windows.Forms.TabPage tabPageMedicines;
        private System.Windows.Forms.TabPage tabPageTreatments;
        private _hospital_database_data_setTableAdapters.WatchmenTableAdapter watchmenTableAdapter;
        private System.Windows.Forms.BindingSource watchmenBindingSource;
        private System.Windows.Forms.DataGridView watchmenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private _hospital_database_data_setTableAdapters.ApprenticesTableAdapter apprenticesTableAdapter;
        private System.Windows.Forms.BindingSource apprenticesBindingSource;
        private System.Windows.Forms.DataGridView apprenticesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private _hospital_database_data_setTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private _hospital_database_data_setTableAdapters.BillsTableAdapter billsTableAdapter;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private System.Windows.Forms.DataGridView billsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private _hospital_database_data_setTableAdapters.MedicinesTableAdapter medicinesTableAdapter;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private System.Windows.Forms.DataGridView medicinesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.TabPage tabPageTreatmentsMedicines;
        private System.Windows.Forms.TabPage tabPageDoctorsPartners;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.TabPage tabPageICUs;
        private System.Windows.Forms.TabPage tabPageOperationTheaters;
        private _hospital_database_data_setTableAdapters.TreatmentsMedicinesTableAdapter treatmentsMedicinesTableAdapter;
        private System.Windows.Forms.BindingSource treatmentsMedicinesBindingSource;
        private System.Windows.Forms.DataGridView treatmentsMedicinesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.BindingSource doctorsPartnersBindingSource;
        private _hospital_database_data_setTableAdapters.DoctorsPartnersTableAdapter doctorsPartnersTableAdapter;
        private System.Windows.Forms.DataGridView doctorsPartnersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private _hospital_database_data_setTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.BindingSource iCUsBindingSource;
        private _hospital_database_data_setTableAdapters.ICUsTableAdapter iCUsTableAdapter;
        private System.Windows.Forms.DataGridView iCUsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.BindingSource operationTheatersBindingSource;
        private _hospital_database_data_setTableAdapters.OperationTheatersTableAdapter operationTheatersTableAdapter;
        private System.Windows.Forms.DataGridView operationTheatersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.TabPage tabPagePartners;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.TabPage tabPageShifts;
        private System.Windows.Forms.TabPage tabPageViewDoctorShifts;
        private System.Windows.Forms.TabPage tabPageViewNursesShifts;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private _hospital_database_data_setTableAdapters.PartnersTableAdapter partnersTableAdapter;
        private System.Windows.Forms.DataGridView partnersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private _hospital_database_data_setTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private System.Windows.Forms.BindingSource shiftsBindingSource;
        private _hospital_database_data_setTableAdapters.ShiftsTableAdapter shiftsTableAdapter;
        private System.Windows.Forms.DataGridView shiftsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;
        private System.Windows.Forms.BindingSource viewDoctorsShiftsBindingSource;
        private _hospital_database_data_setTableAdapters.ViewDoctorsShiftsTableAdapter viewDoctorsShiftsTableAdapter;
        private System.Windows.Forms.DataGridView viewDoctorsShiftsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;
        private System.Windows.Forms.BindingSource viewNursesShiftsBindingSource;
        private _hospital_database_data_setTableAdapters.ViewNursesShiftsTableAdapter viewNursesShiftsTableAdapter;
        private System.Windows.Forms.DataGridView viewNursesShiftsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;
        private System.Windows.Forms.TabPage tabPageViewWatchmenShifts;
        private System.Windows.Forms.BindingSource viewWatchmenShiftsBindingSource;
        private _hospital_database_data_setTableAdapters.ViewWatchmenShiftsTableAdapter viewWatchmenShiftsTableAdapter;
        private System.Windows.Forms.DataGridView viewWatchmenShiftsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;
        private System.Windows.Forms.BindingSource treatmentsBindingSource;
        private _hospital_database_data_setTableAdapters.TreatmentsTableAdapter treatmentsTableAdapter;
        private System.Windows.Forms.DataGridView treatmentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn93;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn94;
    }
}

