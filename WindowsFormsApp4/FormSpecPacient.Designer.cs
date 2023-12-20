namespace WindowsFormsApp4
{
    partial class FormSpecPacient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpecPacient));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDврачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ИНН = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Специализация = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.poliklinikaDataSet2 = new WindowsFormsApp4.PoliklinikaDataSet2();
            this.poliklinikaDataSet = new WindowsFormsApp4.PoliklinikaDataSet();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new WindowsFormsApp4.PoliklinikaDataSetTableAdapters.DoctorsTableAdapter();
            this.poliklinikaDataSet1 = new WindowsFormsApp4.PoliklinikaDataSet1();
            this.doctorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter1 = new WindowsFormsApp4.PoliklinikaDataSet1TableAdapters.DoctorsTableAdapter();
            this.doctorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter2 = new WindowsFormsApp4.PoliklinikaDataSet2TableAdapters.DoctorsTableAdapter();
            this.fKDoctorsScIDвр4316F928BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsScheduleTableAdapter = new WindowsFormsApp4.PoliklinikaDataSetTableAdapters.DoctorsScheduleTableAdapter();
            this.fKDoctorsScIDвр4316F928BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorsScIDвр4316F928BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorsScIDвр4316F928BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDврачаDataGridViewTextBoxColumn,
            this.ИНН,
            this.Имя,
            this.Фамилия,
            this.Специализация});
            this.dataGridView1.DataSource = this.doctorsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(33, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDврачаDataGridViewTextBoxColumn
            // 
            this.iDврачаDataGridViewTextBoxColumn.DataPropertyName = "ID_врача";
            this.iDврачаDataGridViewTextBoxColumn.HeaderText = "ID_врача";
            this.iDврачаDataGridViewTextBoxColumn.Name = "iDврачаDataGridViewTextBoxColumn";
            // 
            // ИНН
            // 
            this.ИНН.DataPropertyName = "ИНН";
            this.ИНН.HeaderText = "ИНН";
            this.ИНН.Name = "ИНН";
            // 
            // Имя
            // 
            this.Имя.DataPropertyName = "Имя";
            this.Имя.HeaderText = "Имя";
            this.Имя.Name = "Имя";
            // 
            // Фамилия
            // 
            this.Фамилия.DataPropertyName = "Фамилия";
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.Name = "Фамилия";
            // 
            // Специализация
            // 
            this.Специализация.DataPropertyName = "Специализация";
            this.Специализация.HeaderText = "Специализация";
            this.Специализация.Name = "Специализация";
            // 
            // doctorsBindingSource3
            // 
            this.doctorsBindingSource3.DataMember = "Doctors";
            this.doctorsBindingSource3.DataSource = this.poliklinikaDataSet2;
            // 
            // poliklinikaDataSet2
            // 
            this.poliklinikaDataSet2.DataSetName = "PoliklinikaDataSet2";
            this.poliklinikaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poliklinikaDataSet
            // 
            this.poliklinikaDataSet.DataSetName = "PoliklinikaDataSet";
            this.poliklinikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.poliklinikaDataSet;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // poliklinikaDataSet1
            // 
            this.poliklinikaDataSet1.DataSetName = "PoliklinikaDataSet1";
            this.poliklinikaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsBindingSource1
            // 
            this.doctorsBindingSource1.DataMember = "Doctors";
            this.doctorsBindingSource1.DataSource = this.poliklinikaDataSet1;
            // 
            // doctorsTableAdapter1
            // 
            this.doctorsTableAdapter1.ClearBeforeFill = true;
            // 
            // doctorsBindingSource2
            // 
            this.doctorsBindingSource2.DataMember = "Doctors";
            this.doctorsBindingSource2.DataSource = this.poliklinikaDataSet2;
            // 
            // doctorsTableAdapter2
            // 
            this.doctorsTableAdapter2.ClearBeforeFill = true;
            // 
            // fKDoctorsScIDвр4316F928BindingSource
            // 
            this.fKDoctorsScIDвр4316F928BindingSource.DataMember = "FK__DoctorsSc__ID_вр__4316F928";
            this.fKDoctorsScIDвр4316F928BindingSource.DataSource = this.doctorsBindingSource;
            // 
            // doctorsScheduleTableAdapter
            // 
            this.doctorsScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // fKDoctorsScIDвр4316F928BindingSource1
            // 
            this.fKDoctorsScIDвр4316F928BindingSource1.DataMember = "FK__DoctorsSc__ID_вр__4316F928";
            this.fKDoctorsScIDвр4316F928BindingSource1.DataSource = this.doctorsBindingSource;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 452);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormSpecPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSpecPacient";
            this.Text = "FormSpecPacient";
            this.Load += new System.EventHandler(this.FormSpecPacient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorsScIDвр4316F928BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorsScIDвр4316F928BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PoliklinikaDataSet poliklinikaDataSet;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private PoliklinikaDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDврачаDataGridViewTextBoxColumn;
        private PoliklinikaDataSet1 poliklinikaDataSet1;
        private System.Windows.Forms.BindingSource doctorsBindingSource1;
        private PoliklinikaDataSet1TableAdapters.DoctorsTableAdapter doctorsTableAdapter1;
        private PoliklinikaDataSet2 poliklinikaDataSet2;
        private System.Windows.Forms.BindingSource doctorsBindingSource2;
        private PoliklinikaDataSet2TableAdapters.DoctorsTableAdapter doctorsTableAdapter2;
        private System.Windows.Forms.BindingSource fKDoctorsScIDвр4316F928BindingSource;
        private PoliklinikaDataSetTableAdapters.DoctorsScheduleTableAdapter doctorsScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИНН;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Специализация;
        private System.Windows.Forms.BindingSource doctorsBindingSource3;
        private System.Windows.Forms.BindingSource fKDoctorsScIDвр4316F928BindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}