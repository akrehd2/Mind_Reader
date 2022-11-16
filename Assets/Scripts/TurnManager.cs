using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public static int turnPoint = 1;
    public static int turnNumber = 1;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            if (PlayerCard.playerCardNumber != 0)
            {
                turnPoint *= -1;
                turnNumber += 1;
            }
    }
}
