using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurnButton : MonoBehaviour
{
    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

 
    void Update()
    {

    }

    void OnMouseDown()
    {
        sprite.color = new Color(1, 1, 1, 0.5f);

        if (TurnManager.turnCount == 1 && Count.myNumberCount != 0)
        {
            TurnManager.turnCount += 1;
        }

        if (TurnManager.turnCount == 2 && Count.mySkillCount != 0)
        {
            TurnManager.turnCount += 1;
            SkillPower();
        }
    }

    void OnMouseUp()
    {
        sprite.color = new Color(1, 1, 1, 1f);
    }

    void SkillPower()
    {
        if (Count.mySkillCount == 1)
        {
            Count.myNumberCount += 5;
        }
        if (Count.mySkillCount == 2)
        {
            Count.myNumberCount += Count.myNumberCount;
        }
        if(Count.mySkillCount == 3)
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
