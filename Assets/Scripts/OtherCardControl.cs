using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCardControl : MonoBehaviour
{
    [SerializeField] int otherCardNumber;

    public List<int> noUseNumber = new List<int>()
    { 1,2,3,4,5};
    public int nUNSize = 5;
    public bool cardMove = true;

    void Start()
    {
        
    }

    
    void Update()
    {
        RandomNumber();

        if (TurnManager.turnCount == 2)
        {
            if (Count.otherNumberCount == otherCardNumber)
            {
                transform.position = new Vector3(-8, 0, 0);
                cardMove = false;
            }
        }

        SkillThree();
    }

    void RandomNumber()
    {
        if (TurnManager.turnCount == 2 && Count.otherNumberCount == 0)
        {
            int i = Random.Range(0, nUNSize);
            Count.otherNumberCount = noUseNumber[i];
            noUseNumber.RemoveAt(i);
            nUNSize -= 1;
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
                        transform.position = new Vector3(8, 0, 0);
                    }
                }
            }
        }
    }
}
