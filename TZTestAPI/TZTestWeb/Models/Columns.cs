using Reinforced.Typings.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TZTestWeb.Models
{
    [TsClass]
    public class ColumnsSection
    {

        public IEnumerable<LockersSection> Columns { get; set; }
    }
}
