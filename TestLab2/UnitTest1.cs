using lab2;

namespace TestLab2
{
    public class Tests
    {
        [Test]
        public void TestEcho()
        {
            var result = Woorrrddddssssss.Word("echo");
            Assert.That(result, Is.EqualTo("ecchhhoooo"));
        }

        [Test]
        public void TestSp()
        {
            var result = Woorrrddddssssss.Word("  ");
            Assert.That(result, Is.EqualTo("   "));
        }

        [Test]
        public void TestArgsInput()
        {
            string[] args = { "echo" };
            var result = Woorrrddddssssss.Word(args[0]);
            Assert.That(result, Is.EqualTo("ecchhhoooo"));
        }

        [Test]
        public void TestOutputGoesToStdout()
        {
            using var sw = new StringWriter();
            Console.SetOut(sw);

            string[] args = { "echo" };
            var result = Woorrrddddssssss.Main(args);

            string stdoutOutput = sw.ToString().Trim();

            Assert.That(stdoutOutput, Is.EqualTo("ecchhhoooo"));
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void TestErrorGoesToStderr()
        {
            using var sw = new StringWriter();
            Console.SetError(sw);

            string[] args = { };
            var result = Woorrrddddssssss.Main(args);

            string stderrOutput = sw.ToString().Trim();

            Assert.That(stderrOutput, Is.EqualTo("No args?"));
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void TestErrorExitCode()
        {
            string[] args = { };
            var result = Woorrrddddssssss.Main(args);

            Assert.That(result, Is.EqualTo(1));
        }

    }
}