using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurnButton : MonoBehaviour
{
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (TurnManager.turnCount == 1 && Count.myNumberCount != 0)
        {
            TurnManager.turnCount += 1;
        }
    }
}
