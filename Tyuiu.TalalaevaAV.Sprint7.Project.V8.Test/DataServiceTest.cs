using Tyuiu.TalalaevaAV.Sprint7.Project.V8.Lib;
namespace Tyuiu.TalalaevaAV.Sprint7.Project.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestClass]
        public class DriverManagerTests
        {
            [TestMethod]
            public void TestAddDriver()
            {
                var driverManager = new DriverManager();
                var driver = new Driver
                {
                    TabNumber = "123",
                    LastName = "Ivanov",
                    FirstName = "Ivan",
                    MiddleName = "Ivanovich",
                    BirthDate = new DateTime(1980, 1, 1),
                    Experience = 10,
                    Salary = 50000
                };
                driverManager.AddDriver(driver);
                Assert.AreEqual(1, driverManager.Drivers.Count);
            }

            [TestMethod]
            public void TestEditDriver()
            {
                var driverManager = new DriverManager();
                var driver = new Driver
                {
                    TabNumber = "123",
                    LastName = "Ivanov",
                    FirstName = "Ivan",
                    MiddleName = "Ivanovich",
                    BirthDate = new DateTime(1980, 1, 1),
                    Experience = 10,
                    Salary = 50000
                };
                driverManager.AddDriver(driver);
                var updatedDriver = new Driver
                {
                    TabNumber = "123",
                    LastName = "Petrov",
                    FirstName = "Petr",
                    MiddleName = "Petrovich",
                    BirthDate = new DateTime(1985, 1, 1),
                    Experience = 15,
                    Salary = 60000
                };
                driverManager.EditDriver(updatedDriver);
                Assert.AreEqual("Petrov", driverManager.Drivers[0].LastName);
            }

            [TestMethod]
            public void TestDeleteDriver()
            {
                var driverManager = new DriverManager();
                var driver = new Driver
                {
                    TabNumber = "123",
                    LastName = "Ivanov",
                    FirstName = "Ivan",
                    MiddleName = "Ivanovich",
                    BirthDate = new DateTime(1980, 1, 1),
                    Experience = 10,
                    Salary = 50000
                };
                driverManager.AddDriver(driver);
                driverManager.DeleteDriver("123");
                Assert.AreEqual(0, driverManager.Drivers.Count);
            }

            [TestMethod]
            public void TestSearchDrivers()
            {
                var driverManager = new DriverManager();
                var driver1 = new Driver
                {
                    TabNumber = "123",
                    LastName = "Ivanov",
                    FirstName = "Ivan",
                    MiddleName = "Ivanovich",
                    BirthDate = new DateTime(1980, 1, 1),
                    Experience = 10,
                    Salary = 50000
                };
                var driver2 = new Driver
                {
                    TabNumber = "124",
                    LastName = "Petrov",
                    FirstName = "Petr",
                    MiddleName = "Petrovich",
                    BirthDate = new DateTime(1985, 1, 1),
                    Experience = 15,
                    Salary = 60000
                };
                driverManager.AddDriver(driver1);
                driverManager.AddDriver(driver2);
                var results = driverManager.SearchDrivers("Ivan");
                Assert.AreEqual(1, results.Count);
                Assert.AreEqual("Ivanov", results[0].LastName);
            }

            [TestMethod]
            public void TestSortDriversBySalary()
            {
                var driverManager = new DriverManager();
                var driver1 = new Driver
                {
                    TabNumber = "123",
                    LastName = "Ivanov",
                    FirstName = "Ivan",
                    MiddleName = "Ivanovich",
                    BirthDate = new DateTime(1980, 1, 1),
                    Experience = 10,
                    Salary = 50000
                };
                var driver2 = new Driver
                {
                    TabNumber = "124",
                    LastName = "Petrov",
                    FirstName = "Petr",
                    MiddleName = "Petrovich",
                    BirthDate = new DateTime(1985, 1, 1),
                    Experience = 15,
                    Salary = 60000
                };
                driverManager.AddDriver(driver1);
                driverManager.AddDriver(driver2);
                driverManager.SortDriversBySalary();
                Assert.AreEqual(50000, driverManager.Drivers[0].Salary);
                Assert.AreEqual(60000, driverManager.Drivers[1].Salary);
            }

            [TestMethod]
            public void TestFilterDriversByExperience()
            {
                var driverManager = new DriverManager();
                var driver1 = new Driver
                {
                    TabNumber = "123",
                    LastName = "Ivanov",
                    FirstName = "Ivan",
                    MiddleName = "Ivanovich",
                    BirthDate = new DateTime(1980, 1, 1),
                    Experience = 10,
                    Salary = 50000
                };
                var driver2 = new Driver
                {
                    TabNumber = "124",
                    LastName = "Petrov",
                    FirstName = "Petr",
                    MiddleName = "Petrovich",
                    BirthDate = new DateTime(1985, 1, 1),
                    Experience = 15,
                    Salary = 60000
                };
                driverManager.AddDriver(driver1);
                driverManager.AddDriver(driver2);
                var results = driverManager.FilterDriversByExperience(10, 15);
                Assert.AreEqual(2, results.Count);
            }

        }    
            
    }
}