using WaterIntakeManagement.DAL.Interface;
using WaterIntakeManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WaterIntakeManagement.DAL.Repository
{
    public class WaterIntakeManagementService : IWaterIntakeManagementInterface
    {
        private IWaterIntakeManagementRepository _repo;
        public WaterIntakeManagementService(IWaterIntakeManagementRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteWaterIntake(int workoutId)
        {
            var res= _repo.DeleteWaterIntake(workoutId);
            return res;
        }

        public WaterIntake GetWaterIntakeByID(int workoutId)
        {
            return _repo.GetWaterIntakeByID(workoutId);
        }
        public void Save()
        {
            _repo.Save();
        }


        IEnumerable<WaterIntake> IWaterIntakeManagementInterface.GetWaterIntakes()
        {
            return _repo.GetWaterIntakes();
        }

        WaterIntake IWaterIntakeManagementInterface.InsertWaterIntake(WaterIntake workout)
        {
            return _repo.InsertWaterIntake(workout);
        }

        bool IWaterIntakeManagementInterface.UpdateWaterIntake(WaterIntake workout)
        {
            return _repo.UpdateWaterIntake(workout);
        }
    }
}