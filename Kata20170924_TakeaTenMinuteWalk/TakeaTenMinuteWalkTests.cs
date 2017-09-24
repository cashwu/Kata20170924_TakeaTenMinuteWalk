using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170924_TakeaTenMinuteWalk
{
    [TestClass]
    public class TakeaTenMinuteWalkTests
    {
        //  n
        //w   e
        //  s

        [TestMethod]
        public void input_n_should_return_false()
        {
            IsValidWalkShouldFalse(new[] {"n"});
        }

        [TestMethod]
        public void input_n_s_should_return_true()
        {
            IsValidWalkShouldTrue(new[] { "n", "s" });
        }

        [TestMethod]
        public void input_n_n_should_return_false()
        {
            IsValidWalkShouldFalse(new[] { "n", "n" });
        }

        [TestMethod]
        public void input_s_n_should_return_true()
        {
            IsValidWalkShouldTrue(new[] { "s", "n" });
        }

        [TestMethod]
        public void input_e_w_should_return_true()
        {
            IsValidWalkShouldTrue(new[] { "e", "w" });
        }

        [TestMethod]
        public void input_w_e_should_return_true()
        {
            IsValidWalkShouldTrue(new[] { "w", "e" });
        }

        private void IsValidWalkShouldTrue(string[] walk)
        {
            Assert.IsTrue(new Kata().IsValidWalk(walk));
        }

        private void IsValidWalkShouldFalse(string[] walk)
        {
            Assert.IsFalse(new Kata().IsValidWalk(walk));
        }
    }

    public class Kata
    {
        public bool IsValidWalk(string[] walk)
        {
            if (walk.Length == 1)
            {
                return false;
            }

            if (walk[0] == "n" && walk[1] == "s" ||
                walk[0] == "s" && walk[1] == "n" ||
                walk[0] == "e" && walk[1] == "w" ||
                walk[0] == "w" && walk[1] == "e")
            {
                return true;
            }

            return false;
        }
    }
}
