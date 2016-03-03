namespace MyPasswords.Library
{
    using System.Collections.Generic;

    public interface IRepository
    {
        IEnumerable<Credentials> Load();
    }
}