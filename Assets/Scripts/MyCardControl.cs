using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCardControl : MonoBehaviour
{
    [SerializeField] int myCardXPos;
    [SerializeField] int myCardNumber;
    public Vector3 cardPos;
    public bool cardMove=true;
    public static bool cardDelete = false;
    public static int firstNumber = 0;

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

            if (cardMove == false && Count.myNumberCount != myCardNumber&&cardDelete==false)
            {
                transform.position = cardPos;
                cardMove = true;
            }
        }

        SkillThree();
        CardDestroy();
    }

    void OnMouseDown()
    {
        if (TurnManager.turnCount == 1&&cardMove==true)
        {
            Count.myNumberCount = myCardNumber;
            firstNumber = myCardNumber;
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
        if (Count.mySkillCount != 4 || Count.otherSkillCount != 4)
        {
            if ((Count.mySkillCount == 3 && Count.otherSkillCount != 3) || (Count.otherSkillCount == 3 && Count.mySkillCount != 3))
            {
                if (TurnManager.turnCount == 3)
                {
                    if (cardMove == false)
                    {
                        transform.position = new Vector3(-8, 0, 0);
                    }
                }
            }
        }
    }

    void CardDestroy()
    {
        if (cardDelete)
        {
            if (gameObject.transform.position==new Vector3(8,0,0)|| gameObject.transform.position == new Vector3(-8, 0, 0))
            {
                cardDelete = false;
                Destroy(gameObject);
            }
        }
    }
}
