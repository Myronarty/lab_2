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
            var result = Woorrrddddssssss.FromArgs(args);
            Assert.That(result, Is.EqualTo("ecchhhoooo"));
        }

        [Test]
        public void TestOutputGoesToStdout()
        {
            using var sw = new StringWriter();
            Console.SetOut(sw);

            string[] args = { "echo" };
            var result = Woorrrddddssssss.FromArgs(args);

            Console.WriteLine(result);

            string stdoutOutput = sw.ToString().Trim();

            Assert.That(stdoutOutput, Is.EqualTo("ecchhhoooo"));
        }

        [Test]
        public void TestErrorGoesToStderr()
        {
            using var sw = new StringWriter();
            Console.SetError(sw);

            string[] args = { };
            var result = Woorrrddddssssss.FromArgs(args);

            string stderrOutput = sw.ToString().Trim();

            Assert.That(stderrOutput, Is.EqualTo("No args?"));
            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public void TestErrorExitCode()
        {
            string[] args = { };
            var result = Woorrrddddssssss.FromArgs(args);

            if (result != null)
            {
                Environment.ExitCode = 0;
            }
            else
            {
                Environment.ExitCode = 1;
            }

            Assert.That(Environment.ExitCode, Is.EqualTo(1));
        }

    }
}