using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timesheetdemo.CRUD.Model;

namespace timesheetdemo.CRUD.Services
{
    public interface ICustomerService
    {
        List<TimeSheet> GetTimeSheets();
        TimeSheet GetTimeSheetById(int id);
        void SaveTimeSheet(TimeSheet timeSheet);
        void DeleteTimeSheet(int id);
    }
}
