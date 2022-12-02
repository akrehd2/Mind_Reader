using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCardControl : MonoBehaviour
{
    [SerializeField] int otherCardNumber;

    public List<int> noUseNumber = new List<int>()
    { 1,2,3,4,5};
    public int nUNSize = 5;

    void Start()
    {
        
    }

    
    void Update()
    {
        RandomNumber();
        if(Count.otherNumberCount== otherCardNumber)
        {
            transform.position = new Vector3(-8, 0, 0);
        }
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
}