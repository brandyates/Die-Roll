using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// Class that creates a static object to be used with aDie class.
    /// This allows for only a single instance of an object and no new ones to be created.
    /// </summary>
    public class aRandomVariable
    {
        protected static Random rand;
    }
}
