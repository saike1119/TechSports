using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour {
    public Position[] position;
    public int width = 450;
    public int height = 450;
    public int fieldBlock = 4;

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

    public Position getPosition(int num)
    {
        return position[num];
    }

    public Position getFieldPosition(int num){

        int oneBlockWidth = width / fieldBlock;
        int oneBlockHeight = height / fieldBlock;
        Position fieldPosition = new Position(position[num].x * oneBlockWidth - oneBlockWidth / 2,
                                              position[num].y * oneBlockHeight - oneBlockHeight / 2);
        return fieldPosition;
    }
}
