namespace MyPasswords.Library.UnitTests
{
    using System.Collections.Generic;
    using FakeItEasy;
    using FileHelpers;
    using NUnit.Framework;

    public class CsvPersisterTests
    {
        public class WhenSaveIsCalled : ContextSpecification
        {
            private CsvPersister sut;
            private IFileHelperEngine<Credentials> fakeCredentialsFileHelperEngine;
            private const string FileName = "c:\\temp\\tempPass.txt";
            private List<Credentials> fakeCredentials;

            protected override void EstablishContext()
            {
                base.EstablishContext();
                
                fakeCredentialsFileHelperEngine = A.Fake<IFileHelperEngine<Credentials>>();
                sut = new CsvPersister(FileName, fakeCredentialsFileHelperEngine);
                fakeCredentials = new List<Credentials>
                {
                    new Credentials {Account = "Account1", Password = "Password1", Site = "Site1"},
                    new Credentials {Account = "Account2", Password = "Password2", Site = "Site2"}
                };
            }

            protected override void BecauseOf()
            {
                base.BecauseOf();

                sut.Save(fakeCredentials);
            }

            [Test]
            public void ItShouldWriteFile()
            {
                A.CallTo(() => fakeCredentialsFileHelperEngine.WriteFile(FileName, fakeCredentials)).MustHaveHappened(Repeated.Exactly.Once);
            }
        }
    }
}
