namespace NUnit
{
    using NUnit.Framework;

    [TestFixture]
    public class FooTest
    {
        [Test]
        public void DoFooShouldReturnFoo()
        {
            Foo foo = new Foo();
            Assert.AreEqual("foo", foo.DoFoo());
        }
    }
}
