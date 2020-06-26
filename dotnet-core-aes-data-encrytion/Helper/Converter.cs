using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_core_aes_data_encrytion.EntityExtended;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace dotnet_core_aes_data_encrytion.Helper
{
    public sealed class Converter : ValueConverter<string, string>
    {
        public Converter(ConverterMappingHints mappingHints = null)
            : base(x => Tools.AesEncrypt(x), x => Tools.AesDecrypt(x), mappingHints)
        {
        }
    }
}
