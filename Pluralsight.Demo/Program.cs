using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

           var creationResult =  userManager.Create(new IdentityUser("marcos"), "123456");

            Console.WriteLine("Created:{0}", creationResult.Succeeded);
            Console.ReadLine();
        }
    }
}
