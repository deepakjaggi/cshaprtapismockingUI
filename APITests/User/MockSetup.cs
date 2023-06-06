using APIDemo.Models;

namespace ApiTestsUser
{
    public class MockSetup
    {        
        public User GetUserMock(int id)
        {
            User user = new User();
            if (id == 2)
            {
                var userdata = new UserData
                {
                    Id = 2,
                    Email = "janet1.weaver@reqres.in",
                    First_name = "Janet1",
                    Last_name = "Weaver1"
                };
                user = new User
                {
                    Data = userdata
                };
            }            
            return user;
        }
    }
}