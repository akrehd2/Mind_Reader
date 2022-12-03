using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCardControl : MonoBehaviour
{
    [SerializeField] int myCardNumber;
    public Vector3 cardPos;
    public bool cardMove=true;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (TurnManager.turnCount == 1)
        {
            if (Count.myNumberCount != myCardNumber)
            {
                transform.position = cardPos;
                cardMove = true;
            }
        }

        SkillThree();
    }

    void OnMouseDown()
    {
        if (TurnManager.turnCount == 1&&cardMove==true)
        {
            Count.myNumberCount = myCardNumber;
            transform.position = new Vector3(8, 0, 0);
            cardMove = false;
        }
    }

    void SkillThree()
    {
        if(TurnManager.turnCount==3)
        {
            if (cardMove == false)
            {
                transform.position = new Vector3(-8, 0, 0);
            }
        }
    }
}
