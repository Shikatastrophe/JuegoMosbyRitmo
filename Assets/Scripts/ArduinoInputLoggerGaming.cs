using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoInputLoggerGaming : MonoBehaviour
{
   public static int byteGaming;
	SerialPort sp = new SerialPort("COM17", 9600); // set port of your arduino connected to computer

	void Start () {
		sp.Open();
		sp.ReadTimeout = 1;
	}

	void Update () {
		if (sp.IsOpen) {
			try {
                int gaming = sp.ReadByte();
				if (gaming == 1) {
					byteGaming = 1;
                    Debug.Log("Gaming1");
				}
				else if (gaming == 2) {
					byteGaming = 2;
				}
                else if (gaming == 3) {
					byteGaming = 3;
				}
                else if (gaming == 4) {
					byteGaming = 4;
				}
                else if (gaming == 0) {
                    byteGaming = 0;
                    Debug.Log("Gaming0");
                }

			} catch (System.Exception) {
			}
		}
	}
}
