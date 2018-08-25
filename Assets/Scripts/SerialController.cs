using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;
using System.IO.Ports;
using UniRx;

public class SerialController : MonoBehaviour {
    public string portName;
    public int baurate;

    SerialPort serial;
    bool isLoop = true;
    // Use this for initialization

    void Start () {
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
            Debug.Log(message);
        }
    }

    void OnDestroy()
    {
        this.isLoop = false;
        this.serial.Close();
    }
}