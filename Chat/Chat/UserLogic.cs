using System;
namespace Chat
{
    class UserLogic
    {
        public UserLogic(String login,String password,String name,String surname,DateTime birthday,String salt,DateTime registry,String picturePath = default(String))
        {
            this.Login = login;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
            this.Salt = salt;
            this.Registry = registry;
            this.PicturePath = picturePath;
        }
        
        public String Login { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime Birthday { get; set; }
        public String Salt { get; set; }
        public DateTime Registry { get; set; }
        public String PicturePath { get; set; }
    }
}