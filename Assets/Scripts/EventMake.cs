using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Bolt;

public class EventMake : MonoBehaviour
{
    public GameObject sample;
    public UnityEvent RightDown;
    public UnityEvent RightUp;
    public UnityEvent LeftDown;
    public UnityEvent LeftUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            RightDown.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            RightUp.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            LeftDown.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            LeftUp.Invoke();
        }        
    }
}
