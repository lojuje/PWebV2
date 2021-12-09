using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PWebV2.Models;

namespace PWebV2.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Home>> GetItemsAsyncHome(string query);
        Task<IEnumerable<About>> GetItemsAsyncAbout(string query);
        Task<IEnumerable<Project>> GetItemsAsyncProject(string query);
    }
}
