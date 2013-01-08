using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace AboutCustomLogin.Models
{
    public class UserContext
    {
        private UserContext() { }

        public static UserContext Current
        {
            get
            {
                if (HttpContext.Current == null || HttpContext.Current.Session == null)
                    return null;

                if (HttpContext.Current.Session["UserContext"] == null)
                    CreateUserContext(HttpContext.Current.User);

                return (UserContext)HttpContext.Current.Session["UserContext"];
            }
        }

        private static void CreateUserContext(IPrincipal user)
        {
            if (!user.Identity.IsAuthenticated) return;
            var person = Person.Find(user.Identity.Name);
            if (person == null) return;

            var userContext = new UserContext { IsAuthenticated = true, Person = person };

            HttpContext.Current.Session["UserContext"] = userContext;
        }

        public Person Person { get; set; }

        public bool IsAuthenticated { get; private set; }
    }

    public class Person
    {
        static List<Person> people = new List<Person>()
              {
                  new Person(){Username = "mauricio", Name = "Mauricio Lobo"}
              };

        public string Name { get; set; }

        public static Person Find(string username)
        {
            return people.FirstOrDefault(x => x.Username == username);
        }

        public string Username { get; set; }

        public static bool Validate(string username)
        {
            return people.Any(x => x.Username == username);
        }
    }
}