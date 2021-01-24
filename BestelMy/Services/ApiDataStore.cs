using BestelMy.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BestelMy.Services
{
    class ApiDataStore : IDataStore
    {
        public List<Gerecht> GerechtList { get; set; }
        public ApiDataStore()
        {
            HttpClient client = new HttpClient();
            // string json = client.GetStreamAsync("http://www");
        }
        public void AddGerecht(Gerecht todo)
        {
            throw new NotImplementedException();
        }

        public void DeleteGerecht(Gerecht todo)
        {
            throw new NotImplementedException();
        }

        public List<Gerecht> GetAllGerecht()
        {
            throw new NotImplementedException();
        }

        public Task<List<Gerecht>> GetAllGerechtAsync()
        {
            throw new NotImplementedException();
        }
    }
}
