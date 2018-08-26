using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;
using System.IO.Ports;
using UniRx;

public class SerialController : MonoBehaviour {
    public int length = 450;
    public int fieldBlock = 5;

    // 1. serial setting
    public string portName;
    public int baurate;
    public SerialPort serial;
    bool isLoop = true;


    // 2. field setting
    public Field field;
    public GameObject menco;

    public GameObject mTapEffect;


    void Start () {
        field = new Field(length, fieldBlock);
        this.serial = new SerialPort(portName, baurate, Parity.None, 8, StopBits.One);
        string message = this.serial.ReadLine();
        int mappingNum = int.Parse(message);


        try
        {
            this.serial.Open();
        }
        catch (Exception e)
        {
            Debug.Log("can not open serial port");
        }
    }

    void OnDestroy()
    {
        this.isLoop = false;
        this.serial.Close();
    }

    void Update()
    {
        string message = this.serial.ReadLine();
        int mappingNum = int.Parse(message);
        //Debug.Log(mappingNum);

        if ((mappingNum > 0) && (mappingNum < 16))
        {
            //Debug.Log("x: " + field.getFieldPosition(mappingNum).x + ",y: " + field.getFieldPosition(mappingNum).y);
            Instantiate(menco, new Vector3(10, 10, 10f), Quaternion.identity);
            UnityEngine.Object.Instantiate(mTapEffect,
                                           new Vector3(field.getFieldPosition(mappingNum).x, 5f, field.getFieldPosition(mappingNum).y),
                                           Quaternion.Euler(90, 0, 0), transform);
        }
    }
}