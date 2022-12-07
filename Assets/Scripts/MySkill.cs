using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySkill : MonoBehaviour
{
    [SerializeField] int skillXPos;
    [SerializeField] int skillNumber;
    public Vector3 cardPos;
    public Vector3 target;
    public bool skillMouse = true;
    public static bool cardDelete = false;

    AudioSource audio;

    void Start()
    {
        target = cardPos;

        audio = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 2f);

        if (TurnManager.turnCount == 2)
        {
            if (Count.mySkillCount == skillNumber)
            {
                target = new Vector3(16, 0, 20);
                transform.localScale = new Vector3(0.9f, 0.9f, 0);
                skillMouse = false;
            }

            if (skillMouse == false && Count.mySkillCount != skillNumber)
            {
                target = cardPos;
                skillMouse = true;
            }
        }

        if (TurnManager.turnCount != 0 && gameObject.transform.position == new Vector3(27, 0, 1))
        {
            Destroy(gameObject);
        }

        CardDestroy();
    }

    void OnMouseDown()
    {
        if (TurnManager.turnCount == 2)
        {
            if (skillMouse == true)
            {
                Count.mySkillCount = skillNumber;
                audio.Play();
            }
        }
    }

    void OnMouseOver()
    {
        if (TurnManager.turnCount == 2)
        {
            if (Count.mySkillCount != skillNumber && skillMouse == true)
            {
                target = new Vector3(skillXPos, -5, 0);
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
                target = cardPos;
                transform.localScale = new Vector3(0.9f, 0.9f, 0);
            }
        }
    }

    void CardDestroy()
    {
        if (cardDelete)
        {
            if (gameObject.transform.position == new Vector3(16, 0, 20))
            {
                target = new Vector3(27, 0, 1);
                audio.Play();
            }
        }
    }
}
