using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Domain.Interfaces
{
    public interface IExcelManager
    {
        public KeyValuePair<RedisKey, RedisValue>[] ReadData(string filePath);
        
    }
}
