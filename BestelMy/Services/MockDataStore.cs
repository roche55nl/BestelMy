using BestelMy.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestelMy.Services
{
    class MockDataStore : IDataStore
    {

        public List<Gerecht> GerechtList { get; set; }

        public MockDataStore()
        {
            GerechtList = new List<Gerecht>();
         
        }
        public List<Gerecht> GetAllGerecht()
        {
            return GerechtList;
        }
        public Task<List<Gerecht>> GetAllGerechtAsync()
        {
            return Task.FromResult(GerechtList);
        }
        public void AddGerecht(Gerecht gerecht)
        {
            GerechtList.Add(gerecht);

        }
        public void DeleteGerecht(Gerecht gerecht)
        {
            GerechtList.Remove(gerecht);
        }
    }
}
