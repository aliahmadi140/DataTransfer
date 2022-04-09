using System;
using System.Collections.Generic;
using System.Text;
using IronXL;
using System.Linq;
using StackExchange.Redis;
using DataTransfer.Domain.Interfaces;

namespace DataTransfer.Infrastructure.Services
{
    public class ExcelManagerService : IExcelManager
    {


        public KeyValuePair<RedisKey, RedisValue>[] ReadData(string filePath)
        {
            try
            {


                WorkBook workbook = WorkBook.Load(filePath);
                WorkSheet sheet = workbook.WorkSheets.First();

                return sheet.Select(cell => new KeyValuePair<RedisKey, RedisValue>(cell.AddressString, cell.Text)).ToArray();


            }
            catch (Exception)
            {

                throw ;
            }
        }
    }
}
