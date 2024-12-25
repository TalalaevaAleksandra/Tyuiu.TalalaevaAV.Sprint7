using Tyuiu.TalalaevaAV.Sprint7.Project.V8.Lib;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Tyuiu.TalalaevaAV.Sprint7.Project.V8
{
    public partial class FormMain : Form
    {
        private DriverManager driverManager;
        private CSVManager csvManager;
        public FormMain()
        {
            InitializeComponent();
            driverManager = new DriverManager();
            csvManager = new CSVManager();

        }

        private void LoadDataFromCSV()
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*",
                Title = "Загрузить CSV файл"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (csvManager != null)
                    {
                        var drivers = csvManager.LoadFromCSV(openFileDialog.FileName);
                        if (drivers != null)
                        {
                            driverManager.Drivers.Clear();
                            foreach (var driver in drivers)
                            {
                                driverManager.AddDriver(driver);
                            }
                            UpdateDataGridView();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CSVManager не инициализирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonOpenFile_TAV_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void UpdateDataGridView()
        {
            if (driverManager.Drivers != null)
            {
                dataGridViewDrivers_TAV.DataSource = null;
                dataGridViewDrivers_TAV.DataSource = driverManager.Drivers;
                dataGridViewDrivers_TAV.Refresh(); // Обновите DataGridView
            }
        }

        private void buttonAddDriver_TAV_Click(object sender, EventArgs e)
        {
            FormInput FormInput = new FormInput();
            if (FormInput.ShowDialog() == DialogResult.OK)
            {
                driverManager.AddDriver(FormInput.Driver);
                UpdateDataGridView();
            }
        }

        private void buttonEditDriver_TAV_Click(object sender, EventArgs e)
        {
            if (dataGridViewDrivers_TAV.SelectedRows.Count > 0)
            {
                Driver selectedDriver = (Driver)dataGridViewDrivers_TAV.SelectedRows[0].DataBoundItem;
                FormInput editForm = new FormInput(selectedDriver);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    driverManager.EditDriver(editForm.Driver);
                    UpdateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите водителя для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteDriver_TAV_Click(object sender, EventArgs e)
        {
            if (dataGridViewDrivers_TAV.SelectedRows.Count > 0)
            {
                Driver selectedDriver = (Driver)dataGridViewDrivers_TAV.SelectedRows[0].DataBoundItem;
                driverManager.DeleteDriver(selectedDriver.TabNumber);
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите водителя для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchDriver_TAV_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch_TAV.Text;
            var results = driverManager.SearchDrivers(searchTerm);
            dataGridViewDrivers_TAV.DataSource = results;
        }

        private void buttonSortDriver_TAV_Click(object sender, EventArgs e)
        {
            driverManager.SortDriversBySalary();
            UpdateDataGridView();
        }

        private void buttonSaveDriver_TAV_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*",
                Title = "Сохранить CSV файл"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    csvManager.SaveToCSV(driverManager.Drivers, saveFileDialog.FileName);
                    MessageBox.Show("Файл успешно сохранен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLoadDriver_TAV_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*",
                Title = "Загрузить CSV файл"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (csvManager != null)
                    {
                        var drivers = csvManager.LoadFromCSV(openFileDialog.FileName);
                        if (drivers != null)
                        {
                            driverManager.Drivers.Clear();
                            foreach (var driver in drivers)
                            {
                                driverManager.AddDriver(driver);
                            }
                            UpdateDataGridView();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CSVManager не инициализирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*",
                Title = "Load CSV File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (csvManager != null)
                    {
                        var drivers = csvManager.LoadFromCSV(openFileDialog.FileName);
                        if (drivers != null)
                        {
                            driverManager.Drivers.Clear();
                            foreach (var driver in drivers)
                            {
                                driverManager.AddDriver(driver);
                            }
                            UpdateDataGridView();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CSVManager не инициализирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAbout_TAV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void labelSearch_TAV_Click(object sender, EventArgs e)
        {

        }

        private void buttonFilterDriver_TAV_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxMinExperience_TAV.Text, out int minExperience) &&
                int.TryParse(textBoxMaxExperience_TAV.Text, out int maxExperience))
            {
                var filteredDrivers = driverManager.FilterDriversByExperience(minExperience, maxExperience);
                dataGridViewDrivers_TAV.DataSource = filteredDrivers;
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения стажа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStatistics_TAV_Click(object sender, EventArgs e)
        {
            var statistics = driverManager.GetStatistics();
            textBoxStatistics_TAV.Text = $"Всего водителей: {statistics.Count}, Общая зарплата: {statistics.TotalSalary}, Средняя зарплата: {statistics.AverageSalary}, Минимальная зарплата: {statistics.MinSalary}, Максимальная зарплата: {statistics.MaxSalary}";
        }
    }
}
