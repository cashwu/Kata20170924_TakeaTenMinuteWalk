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

        private static void IsValidWalkShouldFalse(string[] walk)
        {
            var kata = new Kata();
            var actual = kata.IsValidWalk(walk);
            Assert.IsFalse(actual);
        }
    }

    public class Kata
    {
        public bool IsValidWalk(string[] walk)
        {
            return false;
        }
    }
}
