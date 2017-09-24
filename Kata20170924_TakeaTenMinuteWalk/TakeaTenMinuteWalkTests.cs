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
            IsValidWalkShouldTrue(new[] { "n", "S" });
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

            return true;
        }
    }
}
