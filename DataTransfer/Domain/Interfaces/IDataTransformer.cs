using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Domain.Interfaces
{
    public interface IDataTransformer
    {
        public bool TransferData(string filePath);

    }
}
