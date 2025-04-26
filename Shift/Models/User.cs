namespace Shift.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; internal set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
    }
}