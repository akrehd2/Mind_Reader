using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    [SerializeField] int bSS;

    public static int myNumberCount=0;
    public static int otherNumberCount = 0;
    public static int mySkillCount = 0;
    public static int otherSkillCount = 0;
    public int count1;
    public int count2;
    public Vector3 bSSPos;

    void Start()
    {
        
    }

    
    void Update()
    {
        count1 = myNumberCount;
        count2 = otherNumberCount;

        if (TurnManager.turnCount>1)
        {
            BSS();
        }

    }

    void BSS()
    {
        if (myNumberCount > otherNumberCount && bSS == 1)
        {
            transform.position = new Vector3(0, 0, 0);
        }
        else if (myNumberCount == otherNumberCount && bSS == 2)
        {
            transform.position = new Vector3(0, 0, 0);
        }
        else if (myNumberCount < otherNumberCount && bSS == 3)
        {
            transform.position = new Vector3(0, 0, 0);
        }
        else
            transform.position = bSSPos;

    }

}
