


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWarehouseSystem
{
    public partial class Form1: Form
    {


        List<Robot> robots = new List<Robot>();
        List<WarehouseTask> tasks = new List<WarehouseTask>();

        public Form1()
        {
            InitializeComponent();
        }

        // This method updates the DataGridView to show robots
        private void RefreshRobotGrid()
        {
            dgvRobots.DataSource = null;
            dgvRobots.DataSource = robots;
        }

        // This method shows battery/service alerts in the ListBox
        private void ShowAlerts()
        {
            lstAlerts.Items.Clear();

            foreach (var robot in robots)
            {
                if (robot.IsLowBattery)
                    lstAlerts.Items.Add($"{robot.RobotModel} - Low battery!");
                if (robot.IsServiceOverdue)
                    lstAlerts.Items.Add($"{robot.RobotModel} - Service overdue!");
                else if (robot.IsServiceDueSoon)
                    lstAlerts.Items.Add($"{robot.RobotModel} - Service due soon.");
            }
        }

        private void RefreshTaskGrid()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = tasks;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRobot_Click(object sender, EventArgs e)
        {
            Robot robot = new Robot
            {
                RobotModel = txtModel.Text,
                MaxLoadCapacity = float.Parse(txtLoad.Text),
                CurrentBatteryLevel = float.Parse(txtBattery.Text),
                LastServiceDate = dtpService.Value,
                IsEmergencyRobot = chkEmergency.Checked
            };

            var context = new ValidationContext(robot);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(robot, context, results, true))
            {
                MessageBox.Show(string.Join("\n", results.Select(r => r.ErrorMessage)));
                return;
            }

            robots.Add(robot);
            RefreshRobotGrid();
            ShowAlerts();

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            WarehouseTask task = new WarehouseTask
            {
                PickLocation = txtPick.Text,
                DropLocation = txtDrop.Text,
                LoadWeight = float.Parse(txtWeight.Text),
                ScheduledStartTime = dtpSchedule.Value,
                RequiresEmergencyRobot = chkTaskEmergency.Checked
            };

            var context = new ValidationContext(task);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(task, context, results, true))
            {
                MessageBox.Show(string.Join("\n", results.Select(r => r.ErrorMessage)));
                return;
            }

            tasks.Add(task);
            RefreshTaskGrid();

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
            {
                MessageBox.Show("Select a task first.");
                return;
            }

            var selectedTask = (WarehouseTask)dgvTasks.CurrentRow.DataBoundItem;

            var robot = robots.FirstOrDefault(r =>
                r.CurrentBatteryLevel >= 25 &&
                r.MaxLoadCapacity >= selectedTask.LoadWeight &&
                (!selectedTask.RequiresEmergencyRobot || r.IsEmergencyRobot));

            if (robot != null)
            {
                MessageBox.Show($"Robot '{robot.RobotModel}' assigned to task at {selectedTask.PickLocation}.");
            }
            else
            {
                MessageBox.Show("No available robot meets the task's requirements.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
