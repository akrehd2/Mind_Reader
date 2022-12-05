using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBlank : MonoBehaviour
{
    public Vector3 blankPos;
    public int blankNumber;
    public Vector3 blank1Pos = new Vector3(-8, 0, 0);
    public Vector3 blank2Pos = new Vector3(-16, 0, 0);

    void Start()
    {
        
    }

    
    void Update()
    {
        if(TurnManager.turnCount==2)
        {
            if(blankNumber==1)
            {
                transform.position = blank1Pos;
            }

            if(blankNumber==2)
            {
                transform.position = blank2Pos;
            }
        }
        else
        {
            transform.position = blankPos;
        }
    }
}
