using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin_Tasks
{
    public partial class TasksPanel : Form
    {
        private TaskCollection taskCollection;
        private Persistence persistence;

        public TasksPanel()
        {
            InitializeComponent();
        }

        private void TasksPanel_Load(object sender, EventArgs e)
        {
            persistence = new Persistence();
            taskCollection = new TaskCollection();

            DataGridViewColumn mainCollumn = new DataGridViewColumn();
            DataGridViewCell mainCell = new DataGridViewTextBoxCell(); 
            mainCollumn.CellTemplate = mainCell;
            mainCollumn.HeaderText = "Student Name";
            mainCollumn.Name = "Studen Name";
            mainCollumn.Visible = true;
            dataGridView1.Columns.Add(mainCollumn);

            
            // Initialize the DataGridView.
            //dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSize = true;


            LoadData();

            // Initialize the form.
            
            this.AutoSize = true;
            this.Text = "DataGridView object binding demo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task newTask = new Task(0, txtTaskTitle.Text);

            taskCollection.AddNewTask(newTask);

            taskCollection.Save();
            
            txtTaskTitle.Clear();
            txtTaskTitle.Focus();

            pnlNotification.Visible = true;
            lblNotificationMessage.Text = "Great! new task added to your list!";

            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            foreach (Task item in taskCollection.Load())
            {

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = item.Title;
                //row.Cells[1].Value = item.Title;

                dataGridView1.Rows.Add(row);
            }
        }
    }
}
