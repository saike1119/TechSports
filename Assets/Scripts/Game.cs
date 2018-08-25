using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public GameObject menco;

    public void createObject(){
        Instantiate(menco, new Vector3(1.0f, 2.0f, 0.0f), Quaternion.identity);
    }
}
