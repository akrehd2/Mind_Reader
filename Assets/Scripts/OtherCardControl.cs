using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCardControl : MonoBehaviour
{
    [SerializeField] int otherCardNumber;

    public List<int> noUseNumber = new List<int>()
    {1,2,3,4,5};
    public int nUNSize = 5;
    public bool cardMove = true;
    public static bool cardDelete = false;
    public int j = 0;

    public Vector3 target;
    public Vector3 CardPos;

    void Start()
    {
        target = CardPos;
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);

        RandomNumber();

        if(TurnManager.turnCount==1)
        {
            j = 0;
        }

        if (TurnManager.turnCount == 2)
        {
            if (Count.otherNumberCount == otherCardNumber)
            {
                transform.position = new Vector3(-8, 0, 0);
                target = new Vector3(-8, 0, 0);
                cardMove = false;
            }
            noUseNumber.Remove(Count.otherNumberCount);
            while(j==0)
            {
                nUNSize -= 1;
                j += 1;
            }
        }

        if (TurnManager.turnCount != 0 && gameObject.transform.position == new Vector3(27, 0, 0))
        {
            Destroy(gameObject);
        }

        SkillThree();
        CardDestroy();
    }

    void RandomNumber()
    {
        if (TurnManager.turnCount == 2 && Count.otherNumberCount == 0)
        {
            int i = Random.Range(0, nUNSize);
            Count.otherNumberCount = noUseNumber[i];
            noUseNumber.Remove(Count.otherNumberCount);
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
                        target = new Vector3(8, 0, 0);
                    }
                }
            }
        }
    }

    void CardDestroy()
    {
        if (cardDelete)
        {
            if (gameObject.transform.position == new Vector3(8, 0, 0) || gameObject.transform.position == new Vector3(-8, 0, 0))
            {
                target = new Vector3(27, 0, 0);
            }
        }
    }
}
