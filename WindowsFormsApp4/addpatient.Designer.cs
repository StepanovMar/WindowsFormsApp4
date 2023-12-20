namespace WindowsFormsApp4
{
    partial class addpatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addpatient));
            this.textBoxИмя = new System.Windows.Forms.TextBox();
            this.textBoxФамилия = new System.Windows.Forms.TextBox();
            this.textBoxАдрес = new System.Windows.Forms.TextBox();
            this.textBoxНомерТелефона = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerДата = new System.Windows.Forms.DateTimePicker();
            this.comboBoxУчасток = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poliklinikaDataSet = new WindowsFormsApp4.PoliklinikaDataSet();
            this.patientsTableAdapter = new WindowsFormsApp4.PoliklinikaDataSetTableAdapters.PatientsTableAdapter();
            this.buttonДобавитьПациента = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonДобавитьВрача = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxСпециализацияВрача = new System.Windows.Forms.TextBox();
            this.textBoxФамилияВрача = new System.Windows.Forms.TextBox();
            this.textBoxИмяВрача = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxИННВрача = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.vv = new System.Windows.Forms.Label();
            this.textBoxПаспортныеДанные = new System.Windows.Forms.TextBox();
            this.textBoxПол = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxИмя
            // 
            this.textBoxИмя.Location = new System.Drawing.Point(613, 112);
            this.textBoxИмя.Name = "textBoxИмя";
            this.textBoxИмя.Size = new System.Drawing.Size(100, 20);
            this.textBoxИмя.TabIndex = 0;
            // 
            // textBoxФамилия
            // 
            this.textBoxФамилия.Location = new System.Drawing.Point(613, 138);
            this.textBoxФамилия.Name = "textBoxФамилия";
            this.textBoxФамилия.Size = new System.Drawing.Size(100, 20);
            this.textBoxФамилия.TabIndex = 1;
            // 
            // textBoxАдрес
            // 
            this.textBoxАдрес.Location = new System.Drawing.Point(613, 164);
            this.textBoxАдрес.Name = "textBoxАдрес";
            this.textBoxАдрес.Size = new System.Drawing.Size(100, 20);
            this.textBoxАдрес.TabIndex = 2;
            // 
            // textBoxНомерТелефона
            // 
            this.textBoxНомерТелефона.Location = new System.Drawing.Point(613, 190);
            this.textBoxНомерТелефона.Name = "textBoxНомерТелефона";
            this.textBoxНомерТелефона.Size = new System.Drawing.Size(100, 20);
            this.textBoxНомерТелефона.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Участок";
            // 
            // dateTimePickerДата
            // 
            this.dateTimePickerДата.Location = new System.Drawing.Point(613, 213);
            this.dateTimePickerДата.Name = "dateTimePickerДата";
            this.dateTimePickerДата.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerДата.TabIndex = 12;
            // 
            // comboBoxУчасток
            // 
            this.comboBoxУчасток.DataSource = this.patientsBindingSource;
            this.comboBoxУчасток.DisplayMember = "ID_участка";
            this.comboBoxУчасток.FormattingEnabled = true;
            this.comboBoxУчасток.Location = new System.Drawing.Point(613, 237);
            this.comboBoxУчасток.Name = "comboBoxУчасток";
            this.comboBoxУчасток.Size = new System.Drawing.Size(100, 21);
            this.comboBoxУчасток.TabIndex = 13;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.poliklinikaDataSet;
            // 
            // poliklinikaDataSet
            // 
            this.poliklinikaDataSet.DataSetName = "PoliklinikaDataSet";
            this.poliklinikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonДобавитьПациента
            // 
            this.buttonДобавитьПациента.Location = new System.Drawing.Point(624, 316);
            this.buttonДобавитьПациента.Name = "buttonДобавитьПациента";
            this.buttonДобавитьПациента.Size = new System.Drawing.Size(75, 23);
            this.buttonДобавитьПациента.TabIndex = 14;
            this.buttonДобавитьПациента.Text = "Добавить";
            this.buttonДобавитьПациента.UseVisualStyleBackColor = true;
            this.buttonДобавитьПациента.Click += new System.EventHandler(this.buttonДобавитьПациента_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Пациент";
            // 
            // buttonДобавитьВрача
            // 
            this.buttonДобавитьВрача.Location = new System.Drawing.Point(117, 219);
            this.buttonДобавитьВрача.Name = "buttonДобавитьВрача";
            this.buttonДобавитьВрача.Size = new System.Drawing.Size(75, 23);
            this.buttonДобавитьВрача.TabIndex = 28;
            this.buttonДобавитьВрача.Text = "Добавить";
            this.buttonДобавитьВрача.UseVisualStyleBackColor = true;
            this.buttonДобавитьВрача.Click += new System.EventHandler(this.buttonДобавитьВрача_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Специализация";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Фамилия";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Имя";
            // 
            // textBoxСпециализацияВрача
            // 
            this.textBoxСпециализацияВрача.Location = new System.Drawing.Point(104, 193);
            this.textBoxСпециализацияВрача.Name = "textBoxСпециализацияВрача";
            this.textBoxСпециализацияВрача.Size = new System.Drawing.Size(100, 20);
            this.textBoxСпециализацияВрача.TabIndex = 18;
            // 
            // textBoxФамилияВрача
            // 
            this.textBoxФамилияВрача.Location = new System.Drawing.Point(106, 141);
            this.textBoxФамилияВрача.Name = "textBoxФамилияВрача";
            this.textBoxФамилияВрача.Size = new System.Drawing.Size(100, 20);
            this.textBoxФамилияВрача.TabIndex = 17;
            // 
            // textBoxИмяВрача
            // 
            this.textBoxИмяВрача.Location = new System.Drawing.Point(106, 115);
            this.textBoxИмяВрача.Name = "textBoxИмяВрача";
            this.textBoxИмяВрача.Size = new System.Drawing.Size(100, 20);
            this.textBoxИмяВрача.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Врач";
            // 
            // textBoxИННВрача
            // 
            this.textBoxИННВрача.Location = new System.Drawing.Point(106, 167);
            this.textBoxИННВрача.Name = "textBoxИННВрача";
            this.textBoxИННВрача.Size = new System.Drawing.Size(100, 20);
            this.textBoxИННВрача.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "ИНН";
            // 
            // vv
            // 
            this.vv.AutoSize = true;
            this.vv.Location = new System.Drawing.Point(496, 293);
            this.vv.Name = "vv";
            this.vv.Size = new System.Drawing.Size(111, 13);
            this.vv.TabIndex = 33;
            this.vv.Text = "Паспортные данные";
            // 
            // textBoxПаспортныеДанные
            // 
            this.textBoxПаспортныеДанные.Location = new System.Drawing.Point(613, 290);
            this.textBoxПаспортныеДанные.Name = "textBoxПаспортныеДанные";
            this.textBoxПаспортныеДанные.Size = new System.Drawing.Size(100, 20);
            this.textBoxПаспортныеДанные.TabIndex = 34;
            // 
            // textBoxПол
            // 
            this.textBoxПол.Location = new System.Drawing.Point(613, 264);
            this.textBoxПол.Name = "textBoxПол";
            this.textBoxПол.Size = new System.Drawing.Size(100, 20);
            this.textBoxПол.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(572, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Пол";
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
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // addpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxПол);
            this.Controls.Add(this.textBoxПаспортныеДанные);
            this.Controls.Add(this.vv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxИННВрача);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonДобавитьВрача);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxСпециализацияВрача);
            this.Controls.Add(this.textBoxФамилияВрача);
            this.Controls.Add(this.textBoxИмяВрача);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonДобавитьПациента);
            this.Controls.Add(this.comboBoxУчасток);
            this.Controls.Add(this.dateTimePickerДата);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxНомерТелефона);
            this.Controls.Add(this.textBoxАдрес);
            this.Controls.Add(this.textBoxФамилия);
            this.Controls.Add(this.textBoxИмя);
            this.Controls.Add(this.pictureBox1);
            this.Name = "addpatient";
            this.Text = "addpatient";
            this.Load += new System.EventHandler(this.addpatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxИмя;
        private System.Windows.Forms.TextBox textBoxФамилия;
        private System.Windows.Forms.TextBox textBoxАдрес;
        private System.Windows.Forms.TextBox textBoxНомерТелефона;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerДата;
        private System.Windows.Forms.ComboBox comboBoxУчасток;
        private PoliklinikaDataSet poliklinikaDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PoliklinikaDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.Button buttonДобавитьПациента;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonДобавитьВрача;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxСпециализацияВрача;
        private System.Windows.Forms.TextBox textBoxФамилияВрача;
        private System.Windows.Forms.TextBox textBoxИмяВрача;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxИННВрача;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label vv;
        private System.Windows.Forms.TextBox textBoxПаспортныеДанные;
        private System.Windows.Forms.TextBox textBoxПол;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}