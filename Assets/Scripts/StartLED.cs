using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using Bolt;
using Ludiq;

public class StartLED : MonoBehaviour
{
    [DllImport("Littlewars_makeSO")]
    private static extern void gled(int signal);

    public void LED()
    {
        gled(8);
    }
}
