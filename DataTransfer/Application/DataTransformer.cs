using DataTransfer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Application
{
    public class DataTransformer:IDataTransformer
    {
        private readonly IExcelManager _excelManager;
        private readonly IRedisCache _redisCache;

        public DataTransformer(IExcelManager excelManager, IRedisCache redisCache)
        {
            _excelManager = excelManager;
            _redisCache = redisCache;
        }

        public bool TransferData(string filePath)
        {
            var data=_excelManager.ReadData(filePath);

            if (data!=null)
            {
               return _redisCache.SaveData(data);
            }
            return false; 
        }
    }
}
