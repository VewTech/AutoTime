using Blazored.LocalStorage;
using Library.Schemas;
using Microsoft.AspNetCore.Components;

namespace Web.Core.Services
{
    public class LocalStorageHelper : ILocalStorageHelper
    {
        // The Local Storage Service
        public ILocalStorageService LocalStorage { get; set; }
        public LocalStorageHelper(ILocalStorageService storageService)
        {
            LocalStorage = storageService;
        }

        // The username the user used to log in
        public async Task<string> GetUsername()
        {
            return await LocalStorage.GetItemAsStringAsync("username");
        }
        public async Task SetUsername(string value)
        {
            await LocalStorage.SetItemAsStringAsync("username", value);
        }

        // The password the user used to log in
        public async Task<string> GetPassword()
        {
            return await LocalStorage.GetItemAsStringAsync("password");
        }
        public async Task SetPassword(string value)
        {
            await LocalStorage.SetItemAsStringAsync("password", value);
        }

        // The list of user saved schedules
        public async Task<List<Schedule>> GetSchedules()
        {
            var schedules = await LocalStorage.GetItemAsync<List<Schedule>>("schedules");
            if (schedules == null) return new List<Schedule>();
            return schedules;
        }
        public async Task SetSchedules(List<Schedule> value)
        {
            await LocalStorage.SetItemAsync("schedules", value);
        }
        public async Task AddSchedule(Schedule value)
        {
            var cachedSchedules = await GetSchedules();
            cachedSchedules.Add(value);
            await LocalStorage.SetItemAsync("schedules", cachedSchedules);
        }
        public async Task<Schedule> GetScheduleById(Guid id)
        {
            var schedules = await GetSchedules();
            foreach(var currentSchedule in schedules)
            {
                if(currentSchedule.IdSchedule == id) return currentSchedule;
            }
            return null;
        }
        public async Task UpdateSchedule(Guid id, Schedule value)
        {
            var schedules = await GetSchedules();
            var index = 0;
            foreach(var currentSchedule in schedules)
            {
                if(currentSchedule.IdSchedule != id) continue;
                index = schedules.IndexOf(currentSchedule);
                break;
            }
            schedules[index] = value;
            await SetSchedules(schedules);
        }
    }
}
