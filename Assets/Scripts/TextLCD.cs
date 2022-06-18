using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class TextLCD : MonoBehaviour
{
    [DllImport("Littlewars_makeSO")]
    private static extern void gtextlcd(int signal, int mHp, int eHp, int end);

    public void appStart()
    {
        gtextlcd(0, 0, 0, 0);
    }

    public void gameStart(int myHp, int enemyHp)
    {
        gtextlcd(1, myHp, enemyHp, 0);
    }

    public void gameWin(int endTime)
    {
        gtextlcd(2, 0, 0, endTime);
    }

    public void gameLose()
    {
        gtextlcd(3, 0, 0, 0);
    }
}
