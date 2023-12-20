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
    public partial class FormRaspisanieVra4 : Form
    {
        public FormRaspisanieVra4()
        {
            InitializeComponent();
        }

        private void FormRaspisanieVra4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet3.DoctorsSchedule". При необходимости она может быть перемещена или удалена.
            this.doctorsScheduleTableAdapter.Fill(this.poliklinikaDataSet3.DoctorsSchedule);

        }
    }
}
