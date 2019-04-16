using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginUsers
{
    public class UserRepository:Singleton<UserRepository>
    {
        private List<User> UserList = new List<User>();
        //private List<User> UserList = (List<User>) HttpContext.Current.Application["userList"];
        //static UserRepository instance = null;
        

        public void UserAdd(User oUser)
        {
            int count = 0;
            count = UserList.Count;
            oUser.IdUser = count + 1;
            UserList.Add(oUser);
        }

        public List<User> UserAll()
        {
            return UserList;
        }

        public User GetUserByEmail(string email,string password)
        {
            User oAux = null;
            foreach(User oUser in UserList)
            {
                if ((oUser.Email == email) && (oUser.Password == password))
                    return oUser;
            }
            return oAux;
        }
    }
}