using System;
using System.Collections.Generic;
using System.Text;
using ProjectPanda.Models;

namespace ProjectPanda.Services
{
    using System.Threading.Tasks;
    using ProjectPanda.Models;
    using System.Linq;

    public class MockDataStore : IDataStore2<DocAvaliable>
    {
        bool isInitialized;
        List<DocAvaliable> DoctorOnCallList;

      

        public async Task<bool> UpdateItemAsync(Item item)
        {
            await InitializeAsync();

            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Item item)
        {
            await InitializeAsync();

            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            await InitializeAsync();

            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            await InitializeAsync();

            return await Task.FromResult(items);
        }

        public Task<bool> PullLatestAsync()
        {
            return Task.FromResult(true);
        }


        public Task<bool> SyncAsync()
        {
            return Task.FromResult(true);
        }

        public async Task InitializeAsync()
        {
            if (isInitialized)
                return;

            items = new List<Item>();
            var _items = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Buy some cat food", Description="The cats are hungry"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Learn F#", Description="Seems like a functional idea"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Learn to play guitar", Description="Noted"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Buy some new candles", Description="Pine and cranberry for that winter feel"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Complete holiday shopping", Description="Keep it a secret!"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Finish a todo list", Description="Done"},


            };

            foreach (Item item in _items)
            {
                items.Add(item);
            }

            isInitialized = true;
        }
        //MyList
        public async Task<bool> AddDoctorsListAsync(DocAvaliable doctorOnCall)
        {
            await InitializeAsync();
            DoctorOnCallList.Add(doctorOnCall);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateDoctorsListAsync(DocAvaliable doctorOnCall)
        {
            await InitializeAsync();

            var _doctorOnCall = DoctorOnCallList.Where((DocAvaliable arg) => arg.Id == ).FirstOrDefault();
            DoctorOnCallList.Remove(_doctorOnCall);
            DoctorOnCallList.Add()

                items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public Task<bool> DeleteDoctorsListAsync(DocAvaliable doctorOnCall)
        {
            throw new NotImplementedException();
        }

        public Task<DocAvaliable> GetDoctorsListAsync(string doctorOnCall)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DocAvaliable>> GetDoctorsListAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task DocInitialize()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DocPullLatestAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DocSyncAsync()
        {
            throw new NotImplementedException();
        }

        _doctorOnCall = new List<DocAvaliable>();
            var _doctorOnCall = new List<DocAvaliable>
            {
                new DocAvaliable {Id = Guid.NewGuid().ToString(), Name="Dr Zulu", Varsity="MBchB(Ukzn)" },
                new DocAvaliable {Id = Guid.NewGuid().ToString(), Name="Dr Naidoo", Varsity="MBchB(Wits)" },
                new DocAvaliable {Id = Guid.NewGuid().ToString(), Name="Dr Duma", Varsity="MBchB(UWC),FC Orth(SA),Mmed Ortho(Natal)" },
                new DocAvaliable {Id = Guid.NewGuid().ToString(), Name="Dr McGhee", Varsity="MBchB(UCT)" },
                new DocAvaliable {Id = Guid.NewGuid().ToString(), Name="Dr Nobody", Varsity="MBchB(UL)" },
                new DocAvaliable {Id = Guid.NewGuid().ToString(), Name="Dr 50Cent", Varsity="MBchB(Stellenbosch)" }
            };

            foreach (Item item in _doctorOnCall)
            {
                items.Add(item);
            }

    isInitialized = true;
    }
}
