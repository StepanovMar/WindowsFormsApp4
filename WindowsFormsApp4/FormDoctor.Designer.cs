namespace WindowsFormsApp4
{
    partial class FormDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctor));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonPac = new System.Windows.Forms.Button();
            this.buttony4 = new System.Windows.Forms.Button();
            this.addpatient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Управление";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 45);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(107, 58);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonPac
            // 
            this.buttonPac.Location = new System.Drawing.Point(125, 45);
            this.buttonPac.Name = "buttonPac";
            this.buttonPac.Size = new System.Drawing.Size(107, 58);
            this.buttonPac.TabIndex = 2;
            this.buttonPac.Text = "Пациенты";
            this.buttonPac.UseVisualStyleBackColor = true;
            this.buttonPac.Click += new System.EventHandler(this.buttonPac_Click);
            // 
            // buttony4
            // 
            this.buttony4.Location = new System.Drawing.Point(12, 109);
            this.buttony4.Name = "buttony4";
            this.buttony4.Size = new System.Drawing.Size(107, 58);
            this.buttony4.TabIndex = 3;
            this.buttony4.Text = "Участок";
            this.buttony4.UseVisualStyleBackColor = true;
            this.buttony4.Click += new System.EventHandler(this.buttony4_Click);
            // 
            // addpatient
            // 
            this.addpatient.Location = new System.Drawing.Point(125, 109);
            this.addpatient.Name = "addpatient";
            this.addpatient.Size = new System.Drawing.Size(107, 58);
            this.addpatient.TabIndex = 4;
            this.addpatient.Text = "Добавить лицо";
            this.addpatient.UseVisualStyleBackColor = true;
            this.addpatient.Click += new System.EventHandler(this.addpatient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Специалисты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addpatient);
            this.Controls.Add(this.buttony4);
            this.Controls.Add(this.buttonPac);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDoctor";
            this.Text = "FormDoctor";
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPac;
        private System.Windows.Forms.Button buttony4;
        private System.Windows.Forms.Button addpatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}