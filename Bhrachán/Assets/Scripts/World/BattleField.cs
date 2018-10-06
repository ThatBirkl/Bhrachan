using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleField
{
    bool[][] activeBattlefield;

    //world coordinates of the center; (50/50)
    int centerX;
    int centerY;



    CombatManager manager;

    /*
     * @param _characters All characters involved in this fight; transferred from CombatManager's timeline
     */
    public BattleField(b_ActorCombat[] _characters, CombatManager _manager)
    {
        

        centerX = 0;
        centerY = 0;

        for (int i = 0; i < _characters.Length; i++)
        {
            centerX += _characters[i].X;
            centerY += _characters[i].Y;
        }
        centerX /= _characters.Length;
        centerY /= _characters.Length;
        InitiateGrid();
    }

    private void InitiateGrid()
    {
        int x = 0;
        int y = 0;
        for (int i = 0; i < activeBattlefield.Length; i++)
        {
            for (int j = 0; j < activeBattlefield[i].Length; j++)
            {
                activeBattlefield[i] = new bool[100];

                x = centerX - (activeBattlefield.Length / 2) + i;
                y = centerY - (activeBattlefield[i].Length / 2) + j;
                activeBattlefield[i][j] = true;

                manager.SetSquare(x, y);
            }
        }
    }
}
