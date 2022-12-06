using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlankCtrl : MonoBehaviour
{
    public GameObject[] num = new GameObject[10];
    public OtherBlank[] scripts = new OtherBlank[10];

    public Vector3 DrawPos = new Vector3(27, 0, 0);
    public Vector3 blank1Pos = new Vector3(-8, 0, 0);
    public Vector3 blank2Pos = new Vector3(-16, 0, 0);

    public static bool turn1 = true;
    public static bool turn2 = true;
    public static bool cardDelete = false;

    void Start()
    {
        for (int i = 1; i <= 5; i++)
        {
            num[i - 1] = GameObject.Find("OtherCardBlank" + (i).ToString());
            scripts[i - 1] = num[i - 1].GetComponent<OtherBlank>();
        }

        for (int i = 6; i <= 10; i++)
        {
            num[i - 1] = GameObject.Find("OtherCardBlank" + (i).ToString());
            scripts[i - 1] = num[i - 1].GetComponent<OtherBlank>();
        }
    }

    void Update()
    {
        if (TurnManager.turnCount == 1 && turn1)
        {
            scripts[Random.Range(5, 9)].target = blank1Pos;
            turn1 = false;
        }
        else if (TurnManager.turnCount == 2 && turn2)
        {
            scripts[Random.Range(0, 4)].target = blank2Pos;
            turn2 = false;
        }
    }
}
