using FileHelpers;

namespace MyPasswords.Library
{
    [DelimitedRecord(",")]
    public class Credentials
    {
        public string Site { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
    }
}