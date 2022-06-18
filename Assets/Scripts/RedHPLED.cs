using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using Bolt;
using Ludiq;

public class RedHPLED : MonoBehaviour
{ 
    [DllImport("Littlewars_makeSO")]
    private static extern void gled(int signal);

    private int ex_hp = 8;

    public void TrunOn(int hp)
    {
        int num = hp * 8 / 20;
        if(hp != 0 && num == 0)
        {
            num = 1;
        }

        if(num != ex_hp)
        {
            //Debug.Log(num);
            gled(num);
            ex_hp = num;
        }
    }
}
