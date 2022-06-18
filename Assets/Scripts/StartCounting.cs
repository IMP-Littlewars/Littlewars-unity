using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class StartCounting : MonoBehaviour
{
    [DllImport("Littlewars_makeSO")]
    private static extern void gsegment(int signal, int time);

    public void start(int timer)
    {
        gsegment(1, timer);
    }

    public void reset()
    {
        gsegment(100, 0);
    }
}