using DataTransfer.Domain.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Infrastructure.Services
{
    public class RedisCacheService : IRedisCache
    {
        private readonly IConnectionMultiplexer _redis;

        public RedisCacheService(IConnectionMultiplexer redis)
        {
            this._redis = redis;
        }

        public bool SaveData(KeyValuePair<RedisKey, RedisValue>[] data)
        {

            var db = _redis.GetDatabase();

            //return proccess is success or failure
            return db.StringSet(data);

        }
    }
}
