using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week4Challenge
{
    [TestClass]
    public class Inheritance_Test
    {
        [TestMethod]
        public void InheritanceExamples()
        {
            var snail = new Invertebrate(true, true, true, false, false, false, "snail", 1);

            var shark = new Fish(true, true, false, true, false, false, "shark", 0);

            var penguin = new Bird(true, false, true, false, true, false, "penguin", 2);

            var pug = new Mammal(2, FoodType.Omnivore, true, false, true, false, "Gigi the Pug", 4);

        }
    }
}
