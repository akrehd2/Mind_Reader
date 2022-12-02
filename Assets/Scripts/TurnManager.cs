using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public static int turnCount = 1;
    public int tc = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        tc = turnCount;
    }
}
