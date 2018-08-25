using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menco : MonoBehaviour {
    int position;

    public void setPosition(int pos){
        this.position = pos;
    }
    public int getPosition(){
        return this.position;
    }
}
