using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

namespace Tests
{
    public class Xor21Tests
    {

        [Test]
        public void xorSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4,10 };
            int[] output = xor21Filter.xor21Func(input);
            int[] expected = { 17, 23, 29, 22, 28, 17,31 };

            CollectionAssert.AreEqual(expected, output);
        }


    }
}
