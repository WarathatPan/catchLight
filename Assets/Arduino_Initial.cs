﻿using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Threading;

public class Arduino_Initial : MonoBehaviour
{
    public static SerialPort sp = new SerialPort("COM3", 9600);
    public static int rot;
    public static int v1, v2, v3, v4, v5, v6, v7, v8, v9;
    // Use this for initialization
    void Start()
    {
        OpenConnection();
    }

    // Update is called once per frame
    void Update()
    {
        // print(UnityReadData());
        try
        {
            string[] s = sp.ReadLine().Split(',');

            v1 = int.Parse(s[0]);
            v2 = int.Parse(s[1]);
            v3 = int.Parse(s[2]);
            v4 = int.Parse(s[3]);
            v5 = int.Parse(s[4]);
            v6 = int.Parse(s[5]);
            v7 = int.Parse(s[6]);
            v8 = int.Parse(s[7]);
            v9 = int.Parse(s[8]);

        }
        catch (System.Exception) { }

    }

    public void OpenConnection()
    {
        if (sp != null)
        {
            if (sp.IsOpen)
            {
                sp.Close();
                print("Closing port, because it was already open!");
            }
            else
            {
                sp.Open(); // opens the connection
                sp.ReadTimeout = 100; //sets the timeout value before reporting error
                print("Port Opend!");
            }
        }
        else
        {
            if (sp.IsOpen)
                print("Port is already open");
            else
                print("Port == null");
        }
    }

    void OnApplicationQuit()
    {
        sp.Close();
    }

    public static void UnitySendData(string m)
    {
        sp.Write(m);
    }

    /* public static string UnityReadData()
     {
         string me;
         try
         {
             return(sp.ReadLine());
         }catch(System.Exception){ return "0"; }

         //return me;
     }*/

}

