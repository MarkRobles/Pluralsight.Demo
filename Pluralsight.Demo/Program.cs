using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = "ely";
            var password = "654321";


            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

           var creationResult =  userManager.Create(new IdentityUser(username), password);

            //Console.WriteLine("Created:{0}", creationResult.Succeeded);
            //Console.ReadLine();
            var user = userManager.FindByName(username);
           var claimResult =  userManager.AddClaim(user.Id,new Claim("given_name","Ely"));

            Console.WriteLine("Claim:{0}", claimResult.Succeeded);
            Console.ReadLine();
        }
    }
}
