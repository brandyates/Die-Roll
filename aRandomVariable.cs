using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// Class that creates a static object to be used with any random class.
    /// Using a static member is beneficial in that it can be used with other classes
    /// and generalizes the random variable to be used with other classes. It also does not
    /// clutter up namespace with function names and manage more complex programs.
    /// It acts in a similar way to const so it cannot be changed after being called
    /// which is great for generating the sequence of random numbers needed for a dice simulation
    /// without needing to create a new object every time you need a random number but it is still
    /// predictable enough to use with seeds to recreate sequences for debugging purposes.
    /// </summary>
    public class aRandomVariable
    {

        /// <summary>
        /// create the random variable that is only usable by classes that inherit the <see cref="aRandomVariable"/> class
        /// </summary>
        protected static Random rand;
    }
}
