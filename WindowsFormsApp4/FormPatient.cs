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
    public partial class FormPatient : Form
    {
        public FormPatient()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            RecordAppointmentForm RecordAppointmentForm = new RecordAppointmentForm(); // Ваша новая форма
            RecordAppointmentForm.ShowDialog(); // Открывает форму 2 как модальное окно
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1(); // Создаем экземпляр формы для врачей
            Form1.Show(); // Показываем форму для врачей
            this.Hide(); // Скрываем текущую форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSpecPacient FormSpecPacient = new FormSpecPacient(); // Ваша новая форма
            FormSpecPacient.ShowDialog(); // Открывает форму 2 как модальное окно
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formy4astok Formy4astok = new Formy4astok(); // Ваша новая форма
            Formy4astok.ShowDialog(); // Открывает форму 2 как модальное окно
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRaspisanieVra4 FormRaspisanieVra4 = new FormRaspisanieVra4(); // Ваша новая форма
            FormRaspisanieVra4.ShowDialog(); // Открывает форму 2 как модальное окно
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormSearchPreparat FormSearchPreparat = new FormSearchPreparat(); // Ваша новая форма
            FormSearchPreparat.ShowDialog(); // Открывает форму 2 как модальное окно
        }
    }
}
