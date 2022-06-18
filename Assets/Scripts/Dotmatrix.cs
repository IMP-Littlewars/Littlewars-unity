using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Dotmatrix : MonoBehaviour
{
    [DllImport("Littlewars_makeSO")]
    private static extern void gdotmatrix(int signal);

    public void matrixStart()
    {
        gdotmatrix(0);
    }

    public void matrixEnd()
    {
        gdotmatrix(100);
    }
}
