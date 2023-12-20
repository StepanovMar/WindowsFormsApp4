namespace WindowsFormsApp4
{
    partial class FormRaspisanieVra4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.poliklinikaDataSet3 = new WindowsFormsApp4.PoliklinikaDataSet3();
            this.doctorsScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsScheduleTableAdapter = new WindowsFormsApp4.PoliklinikaDataSet3TableAdapters.DoctorsScheduleTableAdapter();
            this.iDзаписиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDврачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяокончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доступностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsScheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDзаписиDataGridViewTextBoxColumn,
            this.iDврачаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.времяначалаDataGridViewTextBoxColumn,
            this.времяокончанияDataGridViewTextBoxColumn,
            this.доступностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorsScheduleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // poliklinikaDataSet3
            // 
            this.poliklinikaDataSet3.DataSetName = "PoliklinikaDataSet3";
            this.poliklinikaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsScheduleBindingSource
            // 
            this.doctorsScheduleBindingSource.DataMember = "DoctorsSchedule";
            this.doctorsScheduleBindingSource.DataSource = this.poliklinikaDataSet3;
            // 
            // doctorsScheduleTableAdapter
            // 
            this.doctorsScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // iDзаписиDataGridViewTextBoxColumn
            // 
            this.iDзаписиDataGridViewTextBoxColumn.DataPropertyName = "ID_записи";
            this.iDзаписиDataGridViewTextBoxColumn.HeaderText = "ID_записи";
            this.iDзаписиDataGridViewTextBoxColumn.Name = "iDзаписиDataGridViewTextBoxColumn";
            // 
            // iDврачаDataGridViewTextBoxColumn
            // 
            this.iDврачаDataGridViewTextBoxColumn.DataPropertyName = "ID_врача";
            this.iDврачаDataGridViewTextBoxColumn.HeaderText = "ID_врача";
            this.iDврачаDataGridViewTextBoxColumn.Name = "iDврачаDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // времяначалаDataGridViewTextBoxColumn
            // 
            this.времяначалаDataGridViewTextBoxColumn.DataPropertyName = "Время_начала";
            this.времяначалаDataGridViewTextBoxColumn.HeaderText = "Время_начала";
            this.времяначалаDataGridViewTextBoxColumn.Name = "времяначалаDataGridViewTextBoxColumn";
            // 
            // времяокончанияDataGridViewTextBoxColumn
            // 
            this.времяокончанияDataGridViewTextBoxColumn.DataPropertyName = "Время_окончания";
            this.времяокончанияDataGridViewTextBoxColumn.HeaderText = "Время_окончания";
            this.времяокончанияDataGridViewTextBoxColumn.Name = "времяокончанияDataGridViewTextBoxColumn";
            // 
            // доступностьDataGridViewTextBoxColumn
            // 
            this.доступностьDataGridViewTextBoxColumn.DataPropertyName = "Доступность";
            this.доступностьDataGridViewTextBoxColumn.HeaderText = "Доступность";
            this.доступностьDataGridViewTextBoxColumn.Name = "доступностьDataGridViewTextBoxColumn";
            // 
            // FormRaspisanieVra4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRaspisanieVra4";
            this.Text = "FormRaspisanieVra4";
            this.Load += new System.EventHandler(this.FormRaspisanieVra4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsScheduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PoliklinikaDataSet3 poliklinikaDataSet3;
        private System.Windows.Forms.BindingSource doctorsScheduleBindingSource;
        private PoliklinikaDataSet3TableAdapters.DoctorsScheduleTableAdapter doctorsScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзаписиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDврачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяначалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяокончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn доступностьDataGridViewTextBoxColumn;
    }
}