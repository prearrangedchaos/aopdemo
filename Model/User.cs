using PostSharp.Patterns.Contracts;

namespace AOPDemo.Model
{
    public class User
    {
        [NotEmpty]
        [RegularExpression("^[a-z]{4,16}$", ErrorMessage = "Username is invalid")]
        public string UserName { get; set; }
        [NotEmpty]
        public string FullName { get; set; }

        public override string ToString()
        {
            return "Object User { Username: " + this.UserName + ", Full name: " + this.FullName + " }";
        }

        public User(string userName, string fullName)
        {
            UserName = userName;
            FullName = fullName;
        }
    }
}