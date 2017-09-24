using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        [TestMethod]
        public void input_n_s_n_should_return_false()
        {
            IsValidWalkShouldFalse(new[] { "n", "s", "n" });
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
            var dic = walk.GroupBy(a => a).ToDictionary(a => a.Key, a => a.Count());
            
            if (dic.ContainsKey("n") && dic.ContainsKey("s") && dic["n"] == dic["s"]
                || dic.ContainsKey("e") && dic.ContainsKey("w") && dic["e"] == dic["w"])
            {
                return true;
            }

            return false;
        }
    }
}
