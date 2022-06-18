using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class StartThread : MonoBehaviour
{
    [DllImport("Littlewars_makeSO")]
    private static extern void gsegment_init();

    public void makeThread()
    {
        gsegment_init();
        Debug.Log("START");
    }
}
