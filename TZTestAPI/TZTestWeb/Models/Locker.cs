using Reinforced.Typings.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TZTestWeb.Models
{
    [TsClass]
    public class LockersSection
    {
        public IEnumerable<Locker> Lockers { get; set; }
    }

    [TsClass]
    public class Locker
    {
        public string Name { get; set; }
        public decimal Size { get; set; }
    }
}
