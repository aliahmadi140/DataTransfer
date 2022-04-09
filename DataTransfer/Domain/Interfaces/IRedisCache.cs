using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Domain.Interfaces
{
    public interface IRedisCache
    {
        public bool SaveData(KeyValuePair<RedisKey, RedisValue>[] data);
    }
}
