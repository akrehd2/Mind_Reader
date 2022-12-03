using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySkill : MonoBehaviour
{
    [SerializeField] int skillXPos;
    [SerializeField] int skillNumber;

    public Vector3 cardPos;
    public bool skillMouse = true;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (TurnManager.turnCount == 2)
        {
            if (Count.mySkillCount == skillNumber)
            {
                transform.position = new Vector3(16, 0, 20);
                transform.localScale = new Vector3(0.9f, 0.9f, 0);
                skillMouse = false;
            }

            if (skillMouse == false && Count.mySkillCount != skillNumber)
            {
                transform.position = cardPos;
                skillMouse = true;
            }
        }
    }

    void OnMouseDown()
    {
        if (TurnManager.turnCount == 2)
        {
            if (skillMouse == true)
            {
                Count.mySkillCount = skillNumber;
            }
        }
    }

    void OnMouseOver()
    {
        if (TurnManager.turnCount == 2)
        {
            if (Count.mySkillCount != skillNumber && skillMouse == true)
            {
                transform.position = new Vector3(skillXPos, -5, 10);
                transform.localScale = new Vector3(2, 2, 0);
            }
        }
    }

    void OnMouseExit()
    {
        if (TurnManager.turnCount == 2)
        {
            if (Count.mySkillCount != skillNumber && skillMouse == true)
            {
                transform.position = cardPos;
                transform.localScale = new Vector3(0.9f, 0.9f, 0);
            }
        }
    }


}
