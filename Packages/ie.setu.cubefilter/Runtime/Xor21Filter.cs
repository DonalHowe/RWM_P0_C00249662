using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xor21Filter
{
    public static int xor21(int x)
    {
        int val = x ^ 21;
        return val;
    }

    public static int[] xor21Func(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = xor21(xs[i]);
        }
        return result;
    }

}
