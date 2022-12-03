using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCardControl : MonoBehaviour
{
    [SerializeField] int myCardXPos;
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
            if (Count.mySkillCount == myCardNumber)
            {
                transform.position = new Vector3(8, 0, 0);
                transform.localScale = new Vector3(0.9f, 0.9f, 0);
                cardMove = false;
            }

            if (cardMove == false && Count.myNumberCount != myCardNumber)
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
            transform.localScale = new Vector3(0.9f, 0.9f, 0);
            cardMove = false;
        }
    }
    void OnMouseOver()
    {
        if (TurnManager.turnCount == 1)
        {
            if (Count.myNumberCount != myCardNumber && cardMove == true)
            {
                transform.position = new Vector3(myCardXPos, -5, -1);
                transform.localScale = new Vector3(2, 2, 0);
            }
        }
    }

    void OnMouseExit()
    {
        if (TurnManager.turnCount == 1)
        {
            if (Count.mySkillCount != myCardNumber && cardMove == true)
            {
                transform.position = cardPos;
                transform.localScale = new Vector3(0.9f, 0.9f, 0);
            }
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
