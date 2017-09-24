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

        [TestMethod]
        public void input_n_s_e_should_return_false()
        {
            IsValidWalkShouldFalse(new[] { "n", "s", "e" });
        }

        [TestMethod]
        public void input_n_s_n_s_n_s_n_s_n_s_should_return_true()
        {
            IsValidWalkShouldTrue(new[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" });
        }

        [TestMethod]
        public void input_n_s_n_s_n_s_n_s_n_s_n_should_return_false()
        {
            IsValidWalkShouldFalse(new[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s", "n" });
        }

        [TestMethod]
        public void input_n_s_n_s_n_s_n_s_n_s_n_s_should_return_false()
        {
            IsValidWalkShouldFalse(new[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" });
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
            if (walk.Length > 10)
            {
                return false;
            }

            var dic = new Dictionary<string, int>
            {
                { "n", 0 },{ "s", 0 },{ "e", 0 },{ "w", 0 }
            };

            foreach (var w in walk)
            {
                dic[w] += 1;
            }

            if (dic["n"] == dic["s"] && dic["e"] == dic["w"])
            {
                return true;
            }

            return false;
        }
    }
}
