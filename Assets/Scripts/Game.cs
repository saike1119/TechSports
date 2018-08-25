using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    Menco menco;
    Field field;

    // Use this for initialization
    void Start () {
        menco = new Menco();
        field = new Field();
    }
	
	// Update is called once per frame
	void Update () {
        Position tmp = field.getPosition(1);
        Debug.Log(tmp.x);
        Debug.Log(tmp.y);
        //Debug.Log(field.getPosition(1));
    }
}
