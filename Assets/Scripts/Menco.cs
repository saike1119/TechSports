using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menco : MonoBehaviour {
    public GameObject menco;

    //public void setPosition(int pos){
    //    this.position = pos;
    //}
    //public int getPosition(){
    //    return this.position;
    //}

    public void createObject(int x, int y){
        Instantiate(menco, new Vector3(x, y, 10), Quaternion.identity);
    }
}
