using BestelMy.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestelMy.Services
{
    public interface IDataStore
    {
        List<Gerecht> GerechtList { get; set; }
        List<Gerecht> GetAllGerecht();
        Task<List<Gerecht>> GetAllGerechtAsync();
        void AddGerecht(Gerecht gerecht);
        void DeleteGerecht(Gerecht gerecht);

    }
}
