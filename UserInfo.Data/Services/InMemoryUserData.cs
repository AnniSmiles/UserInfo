using System.Collections.Generic;
using UserInfo.Data.Models;
using System;
using System.Linq;

namespace UserInfo.Data.Services
{
    public class InMemoryUserData : IUserData
    {
        List<User> users;

        public InMemoryUserData()
        {
            users = new List<User>()
            {
                new User{Id=1, Name="Temur", LastName="Tevzadze", PersonalId=420001085718},
                new User{Id=2, Name="Ani", LastName="Qliavishvili", PersonalId=262701085718},
                new User{Id=3, Name="Iko", LastName="Kaliashvili", PersonalId=033001085718},
                new User{Id=4, Name="Davit", LastName="Deivich", PersonalId=033001085718}
            };
        }

        public void Add(User user)
        {
            users.Add(user);
            user.Id = users.Max(r => r.Id) + 1;
        }
        public void Update(User user)
        {
            var existing = Get(user.Id);
            if (existing != null)
            {
                existing.Name = user.Name;
                existing.LastName = user.LastName;
                existing.PersonalId = user.PersonalId;

            }
        }
        public User Get(int id)
        {
            return users.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return users.OrderBy(r => r.Id);
        }

       
    }
}
