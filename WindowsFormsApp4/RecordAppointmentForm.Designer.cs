namespace WindowsFormsApp4
{
    partial class RecordAppointmentForm
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
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poliklinikaDataSet = new WindowsFormsApp4.PoliklinikaDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new WindowsFormsApp4.PoliklinikaDataSetTableAdapters.PatientsTableAdapter();
            this.doctorsTableAdapter = new WindowsFormsApp4.PoliklinikaDataSetTableAdapters.DoctorsTableAdapter();
            this.comboBoxПациент = new System.Windows.Forms.ComboBox();
            this.comboBoxВрач = new System.Windows.Forms.ComboBox();
            this.dateTimePickerДата = new System.Windows.Forms.DateTimePicker();
            this.buttonЗаписать = new System.Windows.Forms.Button();
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKAppointmeIDпа45F365D3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new WindowsFormsApp4.PoliklinikaDataSetTableAdapters.AppointmentsTableAdapter();
            this.poliklinikaDataSet3 = new WindowsFormsApp4.PoliklinikaDataSet3();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter1 = new WindowsFormsApp4.PoliklinikaDataSet3TableAdapters.AppointmentsTableAdapter();
            this.patientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter1 = new WindowsFormsApp4.PoliklinikaDataSet3TableAdapters.PatientsTableAdapter();
            this.doctorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter1 = new WindowsFormsApp4.PoliklinikaDataSet3TableAdapters.DoctorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAppointmeIDпа45F365D3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.poliklinikaDataSet;
            // 
            // poliklinikaDataSet
            // 
            this.poliklinikaDataSet.DataSetName = "PoliklinikaDataSet";
            this.poliklinikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.poliklinikaDataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxПациент
            // 
            this.comboBoxПациент.DataSource = this.patientsBindingSource3;
            this.comboBoxПациент.DisplayMember = "ID_пациента";
            this.comboBoxПациент.FormattingEnabled = true;
            this.comboBoxПациент.Location = new System.Drawing.Point(292, 232);
            this.comboBoxПациент.Name = "comboBoxПациент";
            this.comboBoxПациент.Size = new System.Drawing.Size(121, 21);
            this.comboBoxПациент.TabIndex = 0;
            // 
            // comboBoxВрач
            // 
            this.comboBoxВрач.DataSource = this.doctorsBindingSource1;
            this.comboBoxВрач.DisplayMember = "ID_врача";
            this.comboBoxВрач.FormattingEnabled = true;
            this.comboBoxВрач.Location = new System.Drawing.Point(292, 259);
            this.comboBoxВрач.Name = "comboBoxВрач";
            this.comboBoxВрач.Size = new System.Drawing.Size(121, 21);
            this.comboBoxВрач.TabIndex = 1;
            // 
            // dateTimePickerДата
            // 
            this.dateTimePickerДата.Location = new System.Drawing.Point(268, 286);
            this.dateTimePickerДата.Name = "dateTimePickerДата";
            this.dateTimePickerДата.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerДата.TabIndex = 2;
            // 
            // buttonЗаписать
            // 
            this.buttonЗаписать.Location = new System.Drawing.Point(319, 312);
            this.buttonЗаписать.Name = "buttonЗаписать";
            this.buttonЗаписать.Size = new System.Drawing.Size(75, 23);
            this.buttonЗаписать.TabIndex = 3;
            this.buttonЗаписать.Text = "button1";
            this.buttonЗаписать.UseVisualStyleBackColor = true;
            this.buttonЗаписать.Click += new System.EventHandler(this.buttonЗаписать_Click);
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataMember = "Patients";
            this.patientsBindingSource1.DataSource = this.poliklinikaDataSet;
            // 
            // patientsBindingSource2
            // 
            this.patientsBindingSource2.DataMember = "Patients";
            this.patientsBindingSource2.DataSource = this.poliklinikaDataSet;
            // 
            // fKAppointmeIDпа45F365D3BindingSource
            // 
            this.fKAppointmeIDпа45F365D3BindingSource.DataMember = "FK__Appointme__ID_па__45F365D3";
            this.fKAppointmeIDпа45F365D3BindingSource.DataSource = this.patientsBindingSource1;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // poliklinikaDataSet3
            // 
            this.poliklinikaDataSet3.DataSetName = "PoliklinikaDataSet3";
            this.poliklinikaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.poliklinikaDataSet3;
            // 
            // appointmentsTableAdapter1
            // 
            this.appointmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // patientsBindingSource3
            // 
            this.patientsBindingSource3.DataMember = "Patients";
            this.patientsBindingSource3.DataSource = this.poliklinikaDataSet3;
            // 
            // patientsTableAdapter1
            // 
            this.patientsTableAdapter1.ClearBeforeFill = true;
            // 
            // doctorsBindingSource1
            // 
            this.doctorsBindingSource1.DataMember = "Doctors";
            this.doctorsBindingSource1.DataSource = this.poliklinikaDataSet3;
            // 
            // doctorsTableAdapter1
            // 
            this.doctorsTableAdapter1.ClearBeforeFill = true;
            // 
            // RecordAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonЗаписать);
            this.Controls.Add(this.dateTimePickerДата);
            this.Controls.Add(this.comboBoxВрач);
            this.Controls.Add(this.comboBoxПациент);
            this.Name = "RecordAppointmentForm";
            this.Text = "RecordAppointmentForm";
            this.Load += new System.EventHandler(this.RecordAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAppointmeIDпа45F365D3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PoliklinikaDataSet poliklinikaDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PoliklinikaDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private PoliklinikaDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxПациент;
        private System.Windows.Forms.ComboBox comboBoxВрач;
        private System.Windows.Forms.DateTimePicker dateTimePickerДата;
        private System.Windows.Forms.Button buttonЗаписать;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private System.Windows.Forms.BindingSource patientsBindingSource2;
        private System.Windows.Forms.BindingSource fKAppointmeIDпа45F365D3BindingSource;
        private PoliklinikaDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private PoliklinikaDataSet3 poliklinikaDataSet3;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private PoliklinikaDataSet3TableAdapters.AppointmentsTableAdapter appointmentsTableAdapter1;
        private System.Windows.Forms.BindingSource patientsBindingSource3;
        private PoliklinikaDataSet3TableAdapters.PatientsTableAdapter patientsTableAdapter1;
        private System.Windows.Forms.BindingSource doctorsBindingSource1;
        private PoliklinikaDataSet3TableAdapters.DoctorsTableAdapter doctorsTableAdapter1;
    }
}