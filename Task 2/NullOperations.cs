using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class NullOperations
    {
        public void PerformNullChecks()
        {
            String username = null;

            // Using Ternary Operator
            String userNameChecker = (username != null) ? username : "Username is not available";
            Console.WriteLine(userNameChecker);

            // Using Null-Coalescing Operator
            String userNameChecker2 = username ?? "Username is not available";
            Console.WriteLine(userNameChecker2);

            // Using Null-Coalescing Assignment Operator
            username ??= "DefaultUser";
            Console.WriteLine(username);
        }
    }
}


