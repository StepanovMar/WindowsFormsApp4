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
    public partial class FormSpecPacient : Form
    {
        public FormSpecPacient()
        {
            InitializeComponent();
        }

        private void FormSpecPacient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet.DoctorsSchedule". При необходимости она может быть перемещена или удалена.
            this.doctorsScheduleTableAdapter.Fill(this.poliklinikaDataSet.DoctorsSchedule);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet2.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter2.Fill(this.poliklinikaDataSet2.Doctors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet1.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter1.Fill(this.poliklinikaDataSet1.Doctors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.poliklinikaDataSet.Doctors);

        }
    }
}
