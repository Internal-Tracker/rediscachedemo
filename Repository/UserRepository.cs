using Microsoft.EntityFrameworkCore;
using rediscachedemoazure.Context;
using rediscachedemoazure.Model;
using System;

namespace rediscachedemoazure.Repository
{
    public class UserRepository :IUserRepository
    {
        public UserRepository()
        {
            using (var context = new ApiContext())
            {
                var users = new List<User>
                {
                 new User {
                    UserID=1,
                     UserName="user1",
                     Password ="user1",
                    userAccounts= new List<Account>
                    {
                        new Account
                        {
                            AccountID =101,AccountNumber = Guid.NewGuid().ToString(),AccountBalance = 2001,
                            AccountOpeningDate = new DateTime(2022,01,11).ToString("MM/dd/yyyy"),AccountStatus = "Active"
                        }

                    }


                },
                new User {
                    UserID=2,
                    UserName="user2",
                    Password ="user2",
                    userAccounts= new List<Account>
                    {
                        new Account
                        {
                            AccountID =1002, AccountNumber =  Guid.NewGuid().ToString(),AccountBalance = 2002,
                            AccountOpeningDate = new DateTime(2022,02,12).ToString("MM/dd/yyyy"),AccountStatus = "Active"
                        }

                    }


                },
                 new User {
                    UserID=3,
                     UserName="user3",
                     Password ="user3",
                    userAccounts= new List<Account>
                    {
                        new Account
                        {
                            AccountID =103,AccountNumber =  Guid.NewGuid().ToString(),AccountBalance = 2003,
                            AccountOpeningDate = new DateTime(2022,03,13).ToString("MM/dd/yyyy"),AccountStatus = "Active"
                        }

                    }


                },
                  new User {
                    UserID=4,
                      UserName="user4",
                      Password ="user4",
                    userAccounts= new List<Account>
                    {
                        new Account
                        {
                            AccountID =104,AccountNumber =  Guid.NewGuid().ToString(),AccountBalance = 2004,
                            AccountOpeningDate = new DateTime(2022,04,14).ToString("MM/dd/yyyy"),AccountStatus = "Active"
                        }

                    }


                },
                   new User {
                    UserID=5,
                       UserName="user5",
                       Password ="user5",
                    userAccounts= new List<Account>
                    {
                        new Account
                        {
                            AccountID =105,AccountNumber =  Guid.NewGuid().ToString(),AccountBalance = 2005,
                            AccountOpeningDate = new DateTime(2022,05,15).ToString("MM/dd/yyyy"),AccountStatus = "Active"
                        }

                    }


                }
                };
                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }
        public List<User> GetAllUsers()
        {
            using (var context = new ApiContext())
            {
                var userlist = context.Users.ToList();
                return userlist;
            }
        }

        public User GetById(int id)
        {
            using (var context = new ApiContext())
            {
                User? user = context.Users.FindAsync(id).Result;
                return user;
            }
        }

        public async Task<User> ValidateUser(LoginRequestDto userRequest)
        {
            User? user = null;
            using (var context = new ApiContext())
            {
                user = await context.Users.Include(x => x.userAccounts).FirstOrDefaultAsync(u => u.UserName == userRequest.UserName && u.Password == userRequest.UserPassword);


                // user = await context.Users.FirstOrDefaultAsync(u => u.UserName == userRequest.UserName && u.Password == userRequest.UserPassword);
                return user;
                //if (user != null)
                //{

                //}
            }

        }
    }
}
