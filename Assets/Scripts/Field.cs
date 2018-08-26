using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour {
    public Position[] position;
    public int length, fieldBlock;

    public Field(int l, int f)
    {
        this.length = l;
        this.fieldBlock = f;
        int area = 0;

        position = new Position[fieldBlock * fieldBlock];
        for (int i = 1; i <= fieldBlock; i++)
        {
            for (int j = 1; j <= fieldBlock; j++)
            {
                position[area] = new Position(i, j);
                area++;
            }
        }
    }

    public Position getPosition(int num)
    {
        return position[num];
    }

    public Position getFieldPosition(int num){

        int oneBlockWidth = this.length / fieldBlock;
        int oneBlockHeight = this.length / fieldBlock;
        Position fieldPosition = new Position(position[num].x * oneBlockWidth - oneBlockWidth / 2,
                                              position[num].y * oneBlockHeight - oneBlockHeight / 2);
        return fieldPosition;
    }
}
