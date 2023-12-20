using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void buttonPac_Click(object sender, EventArgs e)
        {
            vra4patiets vra4patiets = new vra4patiets(); // Ваша новая форма
            vra4patiets.ShowDialog(); // Открывает форму 2 как модальное окно
        }

        private void buttony4_Click(object sender, EventArgs e)
        {
            FormArea FormArea = new FormArea(); // Ваша новая форма
            FormArea.ShowDialog(); // Открывает форму 2 как модальное окно
        }

        private void addpatient_Click(object sender, EventArgs e)
        {
            addpatient addpatient = new addpatient(); // Ваша новая форма
            addpatient.ShowDialog(); // Открывает форму 2 как модальное окно
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSpec FormSpec = new FormSpec(); // Ваша новая форма
            FormSpec.ShowDialog(); // Открывает форму 2 как модальное окно
        }
    }
}
