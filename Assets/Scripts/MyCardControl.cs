using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCardControl : MonoBehaviour
{
    [SerializeField] int myCardXPos;
    [SerializeField] int myCardNumber;
    public Vector3 cardPos;
    public Vector3 target;
    public bool cardMove=true;
    public static bool cardDelete = false;
    public static int firstNumber = 0;

    AudioSource audio;

    void Start()
    {
        target = cardPos;

        audio = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 1f);

        if (TurnManager.turnCount == 1)
        {
            if (Count.mySkillCount == myCardNumber)
            {
                target = new Vector3(8, 0, 0);
                transform.localScale = new Vector3(0.9f, 0.9f, 0);
                cardMove = false;
            }

            if (cardMove == false && Count.myNumberCount != myCardNumber&&cardDelete==false)
            {
                target = cardPos;
                cardMove = true;
            }
        }

        if (TurnManager.turnCount != 0 && gameObject.transform.position == new Vector3(27, 0, 0))
        {
            Destroy(gameObject);
        }

        SkillThree();
        CardDestroy();
    }

    void OnMouseDown()
    {
        if (TurnManager.turnCount == 1&&cardMove==true)
        {
            Count.myNumberCount = myCardNumber;
            audio.Play();
            firstNumber = myCardNumber;
            target = new Vector3(8, 0, 0);
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
                target = new Vector3(myCardXPos, -5, -1);
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
                target = cardPos;
                transform.localScale = new Vector3(0.9f, 0.9f, 0);
            }
        }
    }

    void SkillThree()
    {
        if (Count.mySkillCount != 4 && Count.otherSkillCount != 4)
        {
            if ((Count.mySkillCount == 3 && Count.otherSkillCount != 3) || (Count.otherSkillCount == 3 && Count.mySkillCount != 3))
            {
                if (TurnManager.turnCount == 3)
                {
                    if (cardMove == false)
                    {
                        target = new Vector3(-8, 0, 0);
                        audio.Play();
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
                target = new Vector3(27, 0, 0);
                audio.Play();
            }
        }
    }
}
