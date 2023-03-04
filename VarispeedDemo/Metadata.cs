using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarispeedDemo
{
    public class Metadata
    {
        public string WowVersion { get; }
        public string WowBranch { get; }
        public Metadata() {
            WowVersion = "WowPlayer v2.7b";
            WowBranch = "dev";
        }
    }
}
