using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Models;

namespace ProjectPanda.Services
{
    public interface IDataStore2<T>
    {
        Task<bool> AddDoctorsListAsync(T doctorOnCall);
        Task<bool> UpdateDoctorsListAsync(T doctorOnCall);
        Task<bool> DeleteDoctorsListAsync(T doctorOnCall);
        Task<T> GetDoctorsListAsync(string doctorOnCall);
        Task<IEnumerable<T>> GetDoctorsListAsync(bool forceRefresh = false);

        Task DocInitialize();
        Task<bool> DocPullLatestAsync();
        Task<bool> DocSyncAsync();
    }
}

