using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class AddTask : Form
    {
        public DataGridView Grid { get; set; }
        public AddTask(DataGridView grid)
        {
            InitializeComponent();

            CenterToParent();
            Grid = grid;
        }

        public DataGridView GetDataGridView()
        {
            return Grid;
        }

        private void PersonalTaskButton_Click(object sender, EventArgs e)
        {
            Close();
            AddPersonalTask addPersonalTask = new AddPersonalTask(Grid);
            addPersonalTask.ShowDialog();
            Grid = addPersonalTask.GetDataGridView();
        }

        private void TeamTaskbutton_Click_1(object sender, EventArgs e)
        {
            Close();
            AddTeamTask addTeamTask1 = new AddTeamTask(Grid);
            addTeamTask1.ShowDialog();
            Grid = addTeamTask1.GetDataGridView();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
