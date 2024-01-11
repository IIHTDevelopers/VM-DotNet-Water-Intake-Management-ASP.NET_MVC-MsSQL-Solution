
using WaterIntakeManagement.DAL;
using WaterIntakeManagement.DAL.Interface;
using WaterIntakeManagement.DAL.Repository;
using WaterIntakeManagement.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace WaterIntakeManagement.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IWaterIntakeManagementInterface _waterIntakeManagementService;
        public readonly Mock<IWaterIntakeManagementRepository> waterintakemanagementservice = new Mock<IWaterIntakeManagementRepository>();
        private readonly WaterIntake _waterIntake;
        private readonly IEnumerable<WaterIntake> workoutIntakeList;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
        {
            _waterIntakeManagementService = new WaterIntakeManagementService(waterintakemanagementservice.Object);
            _output = output;
            _waterIntake = new WaterIntake
            {
                WaterIntakeEntryId = 1,
                Date = DateTime.Now,
                AmountInMilliliters = 500,
                TimeOfDay = new TimeSpan(10, 0, 0),
                Notes = "Infused with lemon",
                DailyGoalInMilliliters = 2000
            };
            workoutIntakeList = new List<WaterIntake>
            {
                    new WaterIntake
                    {
                       WaterIntakeEntryId = 1,
                        Date = DateTime.Now,
                        AmountInMilliliters = 500,
                        TimeOfDay = new TimeSpan(10, 0, 0),
                        Notes = "Infused with lemon",
                        DailyGoalInMilliliters = 2000
                    },
            new WaterIntake
            {
                        WaterIntakeEntryId = 2,
                        Date = DateTime.Now,
                        AmountInMilliliters = 500,
                        TimeOfDay = new TimeSpan(10, 0, 0), 
                        Notes = "Infused with lemon",
                        DailyGoalInMilliliters = 2000
            },
        };

        }

        [Fact]
        public async Task<bool> Testfor_WaterIntakeEntryId_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                waterintakemanagementservice.Setup(repos => repos.InsertWaterIntake(_waterIntake)).Returns(_waterIntake);
                var result = _waterIntakeManagementService.InsertWaterIntake(_waterIntake);

                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_AmountInMilliliters_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                waterintakemanagementservice.Setup(repos => repos.InsertWaterIntake(_waterIntake)).Returns(_waterIntake);
                var result = _waterIntakeManagementService.InsertWaterIntake(_waterIntake);

                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Notes_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                waterintakemanagementservice.Setup(repos => repos.InsertWaterIntake(_waterIntake)).Returns(_waterIntake);
                var result = _waterIntakeManagementService.InsertWaterIntake(_waterIntake);

                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_DailyGoalInMilliliters_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                waterintakemanagementservice.Setup(repos => repos.InsertWaterIntake(_waterIntake)).Returns(_waterIntake);
                var result = _waterIntakeManagementService.InsertWaterIntake(_waterIntake);


                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}