using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCardControl : MonoBehaviour
{
    [SerializeField] int myCardNumber;
    public Vector3 cardPos;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Count.myNumberCount!=myCardNumber)
        {
            transform.position = cardPos;
        }
    }

    void OnMouseDown()
    {
        if (TurnManager.turnCount == 1)
        {
            Count.myNumberCount = myCardNumber;
            transform.position = new Vector3(8, 0, 0);
        }
    }
}
