namespace MyPasswords.Library.UnitTests
{
    using NUnit.Framework;
    public abstract class ContextSpecification
    {
        [OneTimeSetUp]
        public void TestFixtureSetup()
        {
            EstablishContext();
            BecauseOf();
        
        }

        protected virtual void EstablishContext() {}

        protected virtual void BecauseOf() { }
            
        [SetUp]
        public virtual void BeforeEach() { }

        [OneTimeTearDown]
        public virtual void AfterAll() { }

        [TearDown]
        public virtual void AfterEach() { }
    }
}