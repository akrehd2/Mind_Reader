using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECard : MonoBehaviour
{
    [SerializeField] int ecardNumber;

    void Start()
    {
        
    }

    void Update()
    {
        MoveCard();
        ECardDestroy();
    }

    void MoveCard()
    {
        if (EnemyCard.enemyCardNumber == ecardNumber)
        {
            transform.position = new Vector3(3.5f, 0, 0);
        }
    }

    void ECardDestroy()
    {
        if (TurnManager.turnPoint==1)
            if (ecardNumber == EnemyCard.enemyCardNumber)
            {
                Destroy(gameObject);
                EnemyCard.enemyCardNumber = 0;
                EnemyCard.ecoN = 0;
            }
    }
}
