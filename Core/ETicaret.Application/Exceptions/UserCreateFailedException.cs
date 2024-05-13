using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Exceptions
{
    internal class UserCreateFailedException : Exception
    {
        public UserCreateFailedException() :base("Kullanıcı Oluşturulurken Beklenmeyen Bir Hatayla Karşılaşıldı!")
        {
        }
    }
}
