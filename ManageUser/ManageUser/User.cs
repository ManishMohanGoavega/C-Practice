namespace ManageUser
{
    public class User
    {
        public string HelloUser (string user)
        {
            return "Hello " + user;
        }

        public bool AuthenticateUser(string user, string passwod)
        {
            if (user == "manish" && passwod == "goavega")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
} 