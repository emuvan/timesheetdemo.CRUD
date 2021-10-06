using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timesheetdemo.CRUD.DbContexts;
using timesheetdemo.CRUD.Model;

namespace timesheetdemo.CRUD.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomerService(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public void DeleteTimeSheet(int id)
        {
            var timesheet = _dbContext.TimeSheets.FirstOrDefault(x => x.Id == id);
            if (timesheet != null)
            {
                _dbContext.TimeSheets.Remove(timesheet);
                _dbContext.SaveChanges();
            }
        }

        public TimeSheet GetTimeSheetById(int id)
        {
            var timesheet = _dbContext.TimeSheets.SingleOrDefault(x => x.Id == id);
            return timesheet;
        }

        public List<TimeSheet> GetTimeSheets()
        {
            return _dbContext.TimeSheets.ToList();
        }

        public void SaveTimeSheet(TimeSheet timeSheet)
        {
            if (timeSheet.Id == 0) _dbContext.TimeSheets.Add(timeSheet);
            else _dbContext.TimeSheets.Update(timeSheet);
            _dbContext.SaveChanges();
        }
    }
}
