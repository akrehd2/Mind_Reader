using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECardOff : MonoBehaviour
{
    [SerializeField] int ecardOff;

    void Start()
    {
        
    }

    void Update()
    {
       ECardOff1();
    }

    public void ECardOff1()
    {
        if(EnemyCard.ecoN==ecardOff)
        {
            Destroy(gameObject);
        }
    }
}
