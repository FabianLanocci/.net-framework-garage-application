using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class UserCollection
    {
        List<User> userCollection = new List<User>();

        public void Add(User user)
        {
            userCollection.Add(user);
        }

        public void RemovebyName(string name)
        {
            foreach (User user in userCollection)
            {
                if (user.UserName == name)
                {
                    userCollection.Remove(user);
                }
            }
        }

        public List<User> GetAll()
        {
            return this.userCollection;
        }

        public User Search(string name)
        {
            foreach (User u in userCollection)
            {
                if (u.UserName == name)
                {
                    return u;
                }
            }
            return null;
        }

        public bool SearchUserByName(string name)
        {
            foreach (User user in userCollection)
            {
                if (user.UserName == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddUsersList(List<User> users)
        {
            foreach (User user in users)
            {
                userCollection.Add(user);
            }
        }
    }
}
