using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public static float WinCount;

    public static void WinCheck()
    {
        if(WinCount == 5)
        {
            print("you win!");
        }
        else
        {
            print("win count is now " + WinCondition.WinCount);
        }
    }
}
