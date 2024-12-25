using System.Globalization;

namespace Tyuiu.TalalaevaAV.Sprint7.Project.V8.Lib
{
    public class Driver
    {
        public string TabNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Experience { get; set; }
        public decimal Salary { get; set; }
    }

    public class DriverManager
    {
        public List<Driver> Drivers { get; set; }

        public DriverManager()
        {
            Drivers = new List<Driver>();
        }

        public void AddDriver(Driver driver)
        {
            Drivers.Add(driver);
        }

        public void EditDriver(Driver driver)
        {
            var existingDriver = Drivers.FirstOrDefault(d => d.TabNumber == driver.TabNumber);
            if (existingDriver != null)
            {
                existingDriver.LastName = driver.LastName;
                existingDriver.FirstName = driver.FirstName;
                existingDriver.MiddleName = driver.MiddleName;
                existingDriver.BirthDate = driver.BirthDate;
                existingDriver.Experience = driver.Experience;
                existingDriver.Salary = driver.Salary;
            }
        }

        public void DeleteDriver(string tabNumber)
        {
            var driver = Drivers.FirstOrDefault(d => d.TabNumber == tabNumber);
            if (driver != null)
            {
                Drivers.Remove(driver);
            }
        }

        public List<Driver> SearchDrivers(string searchTerm)
        {
            return Drivers.Where(d =>
                d.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                d.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                d.MiddleName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void SortDriversBySalary()
        {
            Drivers = Drivers.OrderBy(d => d.Salary).ToList();
        }

        public List<Driver> FilterDriversByExperience(int minExperience, int maxExperience)
        {
            return Drivers.Where(d => d.Experience >= minExperience && d.Experience <= maxExperience).ToList();
        }

        public (int Count, decimal TotalSalary, decimal AverageSalary, decimal MinSalary, decimal MaxSalary) GetStatistics()
        {
            var count = Drivers.Count;
            var totalSalary = Drivers.Sum(d => d.Salary);
            var averageSalary = Drivers.Average(d => d.Salary);
            var minSalary = Drivers.Min(d => d.Salary);
            var maxSalary = Drivers.Max(d => d.Salary);
            return (count, totalSalary, averageSalary, minSalary, maxSalary);
        }
    }
    public class CSVManager
    {
        public void SaveToCSV(List<Driver> drivers, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("TabNumber,LastName,FirstName,.MiddleName,BirthDate,Experience,Salary");
                foreach (var driver in drivers)
                {
                    writer.WriteLine($"{driver.TabNumber},{driver.LastName},{driver.FirstName},{driver.MiddleName},{driver.BirthDate},{driver.Experience},{driver.Salary}");
                }
            }
        }

        public List<Driver> LoadFromCSV(string filePath)
        {
            var drivers = new List<Driver>();
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    reader.ReadLine(); // Пропустить заголовок
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (string.IsNullOrEmpty(line)) continue;
                        var values = line.Split(',');
                        if (values.Length != 7)
                        {
                            throw new Exception("Неверное количество столбцов в файле");
                        }
                        var driver = new Driver
                        {
                            TabNumber = values[0],
                            LastName = values[1],
                            FirstName = values[2],
                            MiddleName = values[3],
                            BirthDate = DateTime.ParseExact(values[4], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                            Experience = int.Parse(values[5]),
                            Salary = decimal.Parse(values[6])
                        };
                        drivers.Add(driver);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка загрузки данных: {ex.Message}");
            }
            return drivers;
        }
    }
}




