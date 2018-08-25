using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour {
    public Position[] position;

    public Field()
    {
        int area = 0;

        position = new Position[16];
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                position[area] = new Position(i, j);
                area++;
            }
        }
    }


    //public int[] getPosition(int num)
    //{
    //    int[] pos = { 1, 1 };
    //    return pos;
    //}

    public Position getPosition(int num)
    {
        return position[num];
    }
}
