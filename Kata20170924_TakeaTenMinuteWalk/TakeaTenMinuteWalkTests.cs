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
            var kata = new Kata();
            var actual = kata.IsValidWalk(new[] {"n"});
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
