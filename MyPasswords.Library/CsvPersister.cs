using System.Collections.Generic;
using FileHelpers;

namespace MyPasswords.Library
{
    using System.IO;

    public class CsvPersister : IPersister
    {
        private readonly string fullFileName;
        private readonly IFileHelperEngine<Credentials> credentialsFileHelperEngine;

        public CsvPersister(string fullFileName, IFileHelperEngine<Credentials> credentialsFileHelperEngine)
        {
            this.fullFileName = fullFileName;
            this.credentialsFileHelperEngine = credentialsFileHelperEngine;
        }

        public void Save(IEnumerable<Credentials> credentialsToSave)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fullFileName));
            credentialsFileHelperEngine.WriteFile(fullFileName, credentialsToSave);
        }
    }
}