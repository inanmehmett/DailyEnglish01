using DailyEnglish.Models;

namespace DailyEnglish.Services
{
    public class SecurityServices
    {
        UsersDAo usersDao = new UsersDAo();

        public SecurityServices()
        {

        }
        public bool IsValid(UserModel user)
        {
            return usersDao.FindUserByNameAndPassword(user);
            //return true if found in the list

        }
    }
}
