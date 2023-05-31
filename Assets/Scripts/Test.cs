using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Test : MonoBehaviour
{
    SerialPort serial = new SerialPort("COM16", 9600);

    // Start is called before the first frame update
    void Start()
    {
        serial.Open();
        serial.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (serial.IsOpen)
        {
            try
            {
                if (serial.ReadByte() == 1)
                {
                    Debug.Log("Gaming");
                }
            }
            catch (System.Exception)
            {
            }
        }
    }
}
