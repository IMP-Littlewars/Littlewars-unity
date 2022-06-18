using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOnButton : MonoBehaviour
{
    Button btnBS;
    Button btnBA;
    Button btnBG;

    Button btnBWU;
    Button btnBSU;
    Button btnBAU;
    Button btnBGU;
    // Start is called before the first frame update
    void Start()
    {
        btnBS = GameObject.Find("Btn BS").GetComponent<Button>();
        btnBA = GameObject.Find("Btn BA").GetComponent<Button>();
        btnBG = GameObject.Find("Btn BG").GetComponent<Button>();


        btnBWU = GameObject.Find("Btn BWU/Btn U").GetComponent<Button>();
        btnBSU = GameObject.Find("Btn BSU/Btn U").GetComponent<Button>();
        btnBAU = GameObject.Find("Btn BAU/Btn U").GetComponent<Button>();
        btnBGU = GameObject.Find("Btn BGU/Btn U").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            btnBS.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            btnBA.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            btnBG.onClick.Invoke();
        }


        if (Input.GetKeyDown(KeyCode.Equals))
        {
            btnBWU.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            btnBSU.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            btnBAU.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            btnBGU.onClick.Invoke();
        }
    }
}
