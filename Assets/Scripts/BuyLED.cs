using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BuyLED : MonoBehaviour
{
    [DllImport("Littlewars_makeSO")]
    private static extern void g4led(int signal);
    public int character;
    public void buyCharacter()
    {
        g4led(character);
    }
}
