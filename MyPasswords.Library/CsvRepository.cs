namespace MyPasswords.Library
{
    using System.Collections.Generic;

    using FileHelpers;

    public class CsvRepository: IRepository
    {
        private readonly string fullFileName;
        private readonly IFileHelperEngine<Credentials> credentialFileHelperEngine;

        public CsvRepository(string fullFileName, IFileHelperEngine<Credentials> credentialFileHelperEngine)
        {
            this.fullFileName = fullFileName;
            this.credentialFileHelperEngine = credentialFileHelperEngine;
        }

        public IEnumerable<Credentials> Load()
        {
            var result = credentialFileHelperEngine.ReadFile(fullFileName);
            return result;
            ;
        }
    }
}