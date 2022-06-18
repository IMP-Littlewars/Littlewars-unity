using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Song : MonoBehaviour
{
    [DllImport("Littlewars_makeSO")]
    private static extern void gpiezo(int signal);

    public void songStart()
    {
        gpiezo(0);
    }

    public void songWin()
    {
        gpiezo(1);
    }

    public void songDefeat()
    {
        gpiezo(2);
    }
}
