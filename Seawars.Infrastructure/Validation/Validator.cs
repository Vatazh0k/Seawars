using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Seawars.Infrastructure.Validation
{
    public static class Validator
    {
        public static bool NullExist(params string[] elements) => elements.ToList().Exists(x => string.IsNullOrWhiteSpace(x));
    }
}
