using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Library
{
    public interface IPersister
    {
        void Save(IEnumerable<Credentials> credentialsToSave);
    }
}
