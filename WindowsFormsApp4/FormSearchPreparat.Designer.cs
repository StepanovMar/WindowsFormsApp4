namespace WindowsFormsApp4
{
    partial class FormSearchPreparat
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
            this.лекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лекарстваTableAdapter = new WindowsFormsApp4.PoliklinikaDataSet3TableAdapters.ЛекарстваTableAdapter();
            this.iDлекарстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.способпримененияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дозировкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниедействияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.побочныеэффектыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDлекарстваDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.способпримененияDataGridViewTextBoxColumn,
            this.дозировкаDataGridViewTextBoxColumn,
            this.описаниедействияDataGridViewTextBoxColumn,
            this.побочныеэффектыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.лекарстваBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // poliklinikaDataSet3
            // 
            this.poliklinikaDataSet3.DataSetName = "PoliklinikaDataSet3";
            this.poliklinikaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // лекарстваBindingSource
            // 
            this.лекарстваBindingSource.DataMember = "Лекарства";
            this.лекарстваBindingSource.DataSource = this.poliklinikaDataSet3;
            // 
            // лекарстваTableAdapter
            // 
            this.лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // iDлекарстваDataGridViewTextBoxColumn
            // 
            this.iDлекарстваDataGridViewTextBoxColumn.DataPropertyName = "ID_лекарства";
            this.iDлекарстваDataGridViewTextBoxColumn.HeaderText = "ID_лекарства";
            this.iDлекарстваDataGridViewTextBoxColumn.Name = "iDлекарстваDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // способпримененияDataGridViewTextBoxColumn
            // 
            this.способпримененияDataGridViewTextBoxColumn.DataPropertyName = "Способ_применения";
            this.способпримененияDataGridViewTextBoxColumn.HeaderText = "Способ_применения";
            this.способпримененияDataGridViewTextBoxColumn.Name = "способпримененияDataGridViewTextBoxColumn";
            // 
            // дозировкаDataGridViewTextBoxColumn
            // 
            this.дозировкаDataGridViewTextBoxColumn.DataPropertyName = "Дозировка";
            this.дозировкаDataGridViewTextBoxColumn.HeaderText = "Дозировка";
            this.дозировкаDataGridViewTextBoxColumn.Name = "дозировкаDataGridViewTextBoxColumn";
            // 
            // описаниедействияDataGridViewTextBoxColumn
            // 
            this.описаниедействияDataGridViewTextBoxColumn.DataPropertyName = "Описание_действия";
            this.описаниедействияDataGridViewTextBoxColumn.HeaderText = "Описание_действия";
            this.описаниедействияDataGridViewTextBoxColumn.Name = "описаниедействияDataGridViewTextBoxColumn";
            // 
            // побочныеэффектыDataGridViewTextBoxColumn
            // 
            this.побочныеэффектыDataGridViewTextBoxColumn.DataPropertyName = "Побочные_эффекты";
            this.побочныеэффектыDataGridViewTextBoxColumn.HeaderText = "Побочные_эффекты";
            this.побочныеэффектыDataGridViewTextBoxColumn.Name = "побочныеэффектыDataGridViewTextBoxColumn";
            // 
            // FormSearchPreparat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSearchPreparat";
            this.Text = "FormSearchPreparat";
            this.Load += new System.EventHandler(this.FormSearchPreparat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PoliklinikaDataSet3 poliklinikaDataSet3;
        private System.Windows.Forms.BindingSource лекарстваBindingSource;
        private PoliklinikaDataSet3TableAdapters.ЛекарстваTableAdapter лекарстваTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDлекарстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn способпримененияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дозировкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниедействияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn побочныеэффектыDataGridViewTextBoxColumn;
    }
}