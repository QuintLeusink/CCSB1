using CCBS1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCBS1.Services
{
    public interface IAppointmentService
    {
        public List<UserViewModel> GetUserList();
        public Task<int> AddUpdate(AppointmentViewModel model);
        public List<AppointmentViewModel> UserAppointments(string userid);
        public List<AppointmentViewModel> AllAppointments();
        public AppointmentViewModel GetById(int id);
    }
}
