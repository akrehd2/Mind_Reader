using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    [SerializeField] int bSS;

    public static int myNumberCount=0;
    public static int otherNumberCount = 0;
    public int count1;
    public int count2;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(TurnManager.turnCount>1)
        {
            BSS();
        }
        count1 = myNumberCount;
        count2 = otherNumberCount;
    }

    void BSS()
    {
        if(myNumberCount> otherNumberCount&&bSS==1)
        {
            transform.position = new Vector3(0, 0, 0);
        }
        if (myNumberCount == otherNumberCount && bSS == 2)
        {
            transform.position = new Vector3(0, 0, 0);
        }
        if (myNumberCount < otherNumberCount && bSS == 3)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
