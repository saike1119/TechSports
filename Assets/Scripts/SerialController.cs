using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;
using System.IO.Ports;
using UniRx;

public class SerialController : MonoBehaviour {
    // 1. serial setting
    public string portName;
    public int baurate;
    public SerialPort serial;
    bool isLoop = true;


    // 2. field setting
    public Field field;
    public GameObject menco;
    

    void Start () {
        field = new Field();
        this.serial = new SerialPort(portName, baurate, Parity.None, 8, StopBits.One);

        try
        {
            this.serial.Open();
            Scheduler.ThreadPool.Schedule(() => ReadData()).AddTo(this);
        }
        catch (Exception e)
        {
            Debug.Log("can not open serial port");
        }
    }

    public void ReadData()
    {
        while (this.isLoop)
        {
            string message = this.serial.ReadLine();
            int mappingNum = int.Parse(message);
            Debug.Log(mappingNum);

            if ((mappingNum > 0) && (mappingNum < 16))
            {
                Debug.Log("x: " + field.getFieldPosition(mappingNum).x + ",y: " + field.getFieldPosition(mappingNum).y);
            }
        }
    }

    void OnDestroy()
    {
        this.isLoop = false;
        this.serial.Close();
    }
}