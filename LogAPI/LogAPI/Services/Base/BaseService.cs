using LogAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogAPI.Services.Base
{
    public abstract class BaseService
    {
        public BaseService(Context db) { Db = db; }
        protected Context Db { get; }
    }
}
