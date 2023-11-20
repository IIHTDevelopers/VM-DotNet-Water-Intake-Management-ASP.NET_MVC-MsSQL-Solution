
using WaterIntakeManagement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterIntakeManagement.DAL.Interface
{
    public interface IWaterIntakeManagementRepository
    {
        IEnumerable<WaterIntake> GetWaterIntakes();
        WaterIntake GetWaterIntakeByID(int waterIntakeId);
        WaterIntake InsertWaterIntake(WaterIntake waterIntake);
        int DeleteWaterIntake(int waterIntakeId);
        bool UpdateWaterIntake(WaterIntake waterIntake);
        void Save();
    }
}