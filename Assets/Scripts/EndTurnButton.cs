using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurnButton : MonoBehaviour
{
    SpriteRenderer sprite;

    public bool isDelay = false;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

 
    void Update()
    {
        if (TurnManager.turnCount == 0 && isDelay == false)
        {
            isDelay = true;
            StartCoroutine(Set());
        }
    }

    void OnMouseDown()
    {
        sprite.color = new Color(1, 1, 1, 0.5f);
        

        if (TurnManager.turnCount == 1 && Count.myNumberCount != 0&&isDelay==false)
        {
            TurnManager.turnCount += 1;
            isDelay = true;
            StartCoroutine(Wait());
        }

        if (TurnManager.turnCount == 2 && Count.mySkillCount != 0 && isDelay == false)
        {
            TurnManager.turnCount += 1;
            SkillPower();
            AiSkillPower();
            isDelay = true;
            StartCoroutine(Wait());
        }

        if (TurnManager.turnCount == 3 && isDelay == false)
        {
            if(Count.myNumberCount> Count.otherNumberCount)
            {
                Count.myScore += 1;
            }
            if (Count.myNumberCount < Count.otherNumberCount)
            {
                Count.otherScore += 1;
            }

            MyCardControl.cardDelete = true;
            OtherCardControl.cardDelete = true;
            OtherSkill.cardDelete = true;
            MySkill.cardDelete = true;
            
            Reset();
            isDelay = true;
            StartCoroutine(Reload());
        }
    }

    void OnMouseUp()
    {
        sprite.color = new Color(1, 1, 1, 1f);
    }

    void SkillPower()
    {
        if (Count.otherSkillCount != 4)
        {
            if (Count.mySkillCount == 1)
            {
                if (Count.otherSkillCount == 3)
                {
                    Count.otherNumberCount += 5;
                    Count.myNumberCount = Count.otherNumberCount;
                }
                else
                {
                    Count.myNumberCount += 5;
                }
            }
            if (Count.mySkillCount == 2)
            {
                if (Count.otherSkillCount == 3)
                {
                    Count.otherNumberCount += Count.otherNumberCount;
                    Count.myNumberCount = Count.otherNumberCount;
                }
                else
                {
                    Count.myNumberCount += Count.myNumberCount;
                }
            }
            if (Count.mySkillCount == 3 && Count.otherSkillCount != 3)
            {
                int i = Count.myNumberCount;
                Count.myNumberCount = Count.otherNumberCount;
                Count.otherNumberCount = i;
            }
            if (Count.mySkillCount == 4)
            {

            }
            if (Count.mySkillCount == 5)
            {

            }
        }
    }

    void AiSkillPower()
    {
        if (Count.mySkillCount != 4)
        {
            if (Count.otherSkillCount == 1)
            {
                Count.otherNumberCount += 5;
            }
            if (Count.otherSkillCount == 2)
            {
                Count.otherNumberCount += Count.otherNumberCount;
            }
            if (Count.otherSkillCount == 3 && Count.mySkillCount != 3)
            {
                int i = Count.otherNumberCount;
                Count.otherNumberCount = MyCardControl.firstNumber;
            }
            if (Count.otherSkillCount == 4)
            {

            }
            if (Count.otherSkillCount == 5)
            {

            }
        }
    }

    void Reset()
    {
        BlankCtrl.turn1 = true;
        BlankCtrl.turn2 = true;
        Count.myNumberCount = 0;
        Count.otherNumberCount = 0;
        Count.mySkillCount = 0;
        Count.otherSkillCount = 0;
        TurnManager.turnCount = 0;
    }

    IEnumerator Set()
    {
        yield return new WaitForSeconds(1.0f);
        TurnManager.turnCount += 1;
        isDelay = false;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.0f);
        isDelay = false;
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(1.0f);
        MyCardControl.cardDelete = false;
        OtherCardControl.cardDelete = false;
        OtherSkill.cardDelete = false;
        MySkill.cardDelete = false;
        isDelay = false;
    }
}
