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

    public int nUSBSize = 5;
    public int nUNBSize = 5;
    public List<int> noUseSkillBlank = new List<int>()
    {0,1,2,3,4};
    public List<int> noUseNumberBlank = new List<int>()
    {5,6,7,8,9};

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
            if (nUNBSize != 0)
            {
                scripts[BRandom2()].target = blank1Pos;
            }
            turn1 = false;
        }
        else if (TurnManager.turnCount == 2 && turn2)
        {
            if (nUSBSize != 0)
            {
                scripts[BRandom1()].target = blank2Pos;
            }
            turn2 = false;
        }
    }

    private int BRandom1()
    {
        int y = Random.Range(0, nUSBSize);
        int z = noUseSkillBlank[y];
        noUseSkillBlank.Remove(z);
        nUSBSize -= 1;
        return z;
    }

    private int BRandom2()
    {
            int y = Random.Range(0, nUNBSize);
            int z = noUseNumberBlank[y];
            noUseNumberBlank.Remove(z);
            nUNBSize -= 1;
            return z;
    }
}
