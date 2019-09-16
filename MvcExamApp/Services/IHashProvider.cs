using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcExamApp.Services
{
    public interface IHashProvider
    {
        string GetHash(string source);
    }
}
