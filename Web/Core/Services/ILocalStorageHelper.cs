using Blazored.LocalStorage;
using Library.Schemas;


namespace Web.Core.Services
{
    public interface ILocalStorageHelper
    {

        // The username the user used to log in
        public Task<string> GetUsername();
        public Task SetUsername(string value);

        // The password the user used to log in
        public Task<string> GetPassword();
        public Task SetPassword(string value);

        // The list of user saved schedules
        public Task<List<Schedule>> GetSchedules();
        public Task SetSchedules(List<Schedule> value);
        public Task AddSchedule(Schedule value);
        public Task<Schedule> GetScheduleById(Guid value);
        public Task UpdateSchedule(Guid id, Schedule value);
    }
}
