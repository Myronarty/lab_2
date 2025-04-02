using lab2;

namespace TestLab2
{
    public class Tests
    {
        [Test]
        public void TestEcho()
        {
            var Woorrrddddssssss = new Woorrrddddssssss();
            var result = Woorrrddddssssss.Word("echo");
            Assert.That(result, Is.EqualTo("ecchhhoooo"));
        }

        [Test]
        public void TestSp()
        {
            var Woorrrddddssssss = new Woorrrddddssssss();
            var result = Woorrrddddssssss.Word("  ");
            Assert.That(result, Is.EqualTo("   "));
        }
    }
}