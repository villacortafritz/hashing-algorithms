using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    interface HashAlgorithm
    {
        String ComputeHash(String filename);
    }
}
