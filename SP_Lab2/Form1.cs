using System.Diagnostics;
using System.Reflection;

namespace SP_Lab2
{
    public partial class Form1 : Form
    {
        private bool isRun = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateProcessList()
        {
            ProcessList.Items.Clear();

            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes.OrderBy(p => p.ProcessName))
            {
                ProcessList.Items.Add($"{process.ProcessName} ---- ID: {process.Id}");
            }
        }

        private void ShowList(object sender, EventArgs e)
        {
            if (!isRun)
            {
                UpdateProcessList();

                processTimer.Interval = 60000;
                processTimer.Tick += new EventHandler(timer1_Tick);
                processTimer.Start();

                isRun = true;
            }
            else
            {
                MessageBox.Show("Is already running");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProcessList();
            MessageBox.Show("Updated");
        }

        private void ProcessList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProcessList.SelectedItem == null)
                return;

            string selectedItem = ProcessList.SelectedItem.ToString();
            int processId = int.Parse(selectedItem.Split(new[] { "ID: " }, StringSplitOptions.None)[1]);

            try
            {
                Process process = Process.GetProcessById(processId);

                string processDetails = $"Ідентифікатор процесу: {process.Id}\n" +
                                        $"Час старту: {process.StartTime}\n" +
                                        $"Загальна кількість процесорного часу: {process.TotalProcessorTime}\n" +
                                        $"Кількість потоків: {process.Threads.Count}\n" +
                                        $"Кількість копій процесу: {Process.GetProcessesByName(process.ProcessName).Length}";

                ProcessDetailsTextBox.Text = processDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void KillButton_Click(object sender, EventArgs e)
        {
            if (ProcessList.SelectedItem == null)
            {
                MessageBox.Show("Select the process");
                return;
            }

            string selectedItem = ProcessList.SelectedItem.ToString();
            int processId = int.Parse(selectedItem.Split(new[] { "ID: " }, StringSplitOptions.None)[1]);

            try
            {
                Process process = Process.GetProcessById(processId);
                process.Kill();
                MessageBox.Show("Process killed successfully");
                UpdateProcessList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in process killing: {ex.Message}");
            }
        }

        private void StopUpdate(object sender, EventArgs e)
        {


            processTimer.Stop();
            ProcessList.Items.Clear();
            ProcessDetailsTextBox.Clear();

            isRun = false;
        }
       
        private void RunProgramm(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                string buttonText = clickedButton.Text;
                if (buttonText == "Notepad")
                {
                    Process.Start("notepad.exe");
                }
                else if (buttonText == "Calculator")
                {
                    Process.Start("calc.exe");
                }
                else if (buttonText == "Paint")
                {
                    Process.Start("mspaint.exe");
                }
                else if (buttonText == "WeatherApp")
                {
                    string filePath = "WPF_WeatherWizard_App.exe";
                    Process.Start(filePath);
                }
                else
                {
                    MessageBox.Show("error command");
                }
            }

        }
    }
}