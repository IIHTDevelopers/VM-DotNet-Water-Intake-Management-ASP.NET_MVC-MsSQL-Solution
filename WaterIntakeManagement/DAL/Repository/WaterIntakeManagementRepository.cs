using WaterIntakeManagement.DAL.Interface;
using WaterIntakeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WaterIntakeManagement.DAL.Repository
{
    public class WaterIntakeManagementRepository : IWaterIntakeManagementRepository
    {
        private WaterIntakeManagementDbContext _context;
        public WaterIntakeManagementRepository(WaterIntakeManagementDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<WaterIntake> GetWaterIntakes()
        {
             return _context.WaterIntakes.ToList();
        }
        public WaterIntake GetWaterIntakeByID(int id)
        {
            return _context.WaterIntakes.Find(id);
        }
        public WaterIntake InsertWaterIntake(WaterIntake workout)
        {
            return _context.WaterIntakes.Add(workout);
        }
        public int DeleteWaterIntake(int workoutID)
        {
            WaterIntake workout = _context.WaterIntakes.Find(workoutID);
            var res= _context.WaterIntakes.Remove(workout);
            return res.WaterIntakeEntryId;
        }
        public bool UpdateWaterIntake(WaterIntake workout)
        {
            var res= _context.Entry(workout).State = EntityState.Modified;
            return res.Equals("workout");
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
