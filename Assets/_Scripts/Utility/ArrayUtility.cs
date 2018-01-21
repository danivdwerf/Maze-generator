﻿using UnityEngine;

public static class ArrayUtility
{
    public static void shuffleArray<T>(ref T[] array)
    {
        int len = array.Length;
        for (int i = 0; i < len; i++)
        {
            int randomIndex = i + (int)(Random.value*100 % (len - i));
            T tmp = array[i];
            array[i] = array[randomIndex];
            array[randomIndex] = tmp;
        }
    }
}
