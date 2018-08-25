using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    Menco menco;
    Field field;
    //SerialController controller;

    // Use this for initialization
    void Start () {
        menco = new Menco();
        field = new Field();
        //controller = new SerialController();
    }
	
	// Update is called once per frame
	void Update () {
        Position tmp = field.getPosition(1);
        //Debug.Log(controller.serial.ReadLine());
    }
}
