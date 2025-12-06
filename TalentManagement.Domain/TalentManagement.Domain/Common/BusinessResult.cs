using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentManagement.Domain.Common
{
    public class BusinessResult<T>
    {
        public bool Success { get; }
        public T Value { get; }
        public string Error { get; }

        private BusinessResult(bool success, T value, string error)
        {
            Success = success;
            Value = value;
            Error = error;
        }

        public static BusinessResult<T> Ok(T value) => new BusinessResult<T>(true, value, null);
        public static BusinessResult<T> Fail(string error) => new BusinessResult<T>(false, default(T), error);
    }
}
