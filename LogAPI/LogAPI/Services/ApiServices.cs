using LogAPI.Data;
using LogAPI.Models;
using LogAPI.Services.Base;
using System.Threading.Tasks;

namespace LogAPI.Services
{
    public class ApiServices : BaseService
    {
        public ApiServices(Context db) : base(db) { }
        public async Task PutLog(LogModel log)
        {
            await Db.Logs.AddAsync(log);
            await Save();
        }

        public async Task Save()
        {
            await Db.SaveChangesAsync();
        }
    }
}
