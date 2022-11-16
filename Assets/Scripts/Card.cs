using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] int cardNumber;

    public Vector3 cardPos;

    void Start()
    {
  
    }

    
    void Update()
    {
        if (TurnManager.turnPoint == 1)
        {
            InputCheatKey();
            ResetCardPosition();
        }

        CardDestroy();
    }

    void InputCheatKey()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (cardNumber == 1)
            {
                transform.position = new Vector3(-3.5f, 0, 0);
                PlayerCard.playerCardNumber = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (cardNumber == 2)
            {
                transform.position = new Vector3(-3.5f, 0, 0);
                PlayerCard.playerCardNumber = 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (cardNumber == 3)
            {
                transform.position = new Vector3(-3.5f, 0, 0);
                PlayerCard.playerCardNumber = 3;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (cardNumber == 4)
            {
                transform.position = new Vector3(-3.5f, 0, 0);
                PlayerCard.playerCardNumber = 4;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (cardNumber == 5)
            {
                transform.position = new Vector3(-3.5f, 0, 0);
                PlayerCard.playerCardNumber = 5;
            }
        }
    }

    void ResetCardPosition()
    {
        if(cardNumber!=PlayerCard.playerCardNumber)
        {
            transform.position = cardPos;
        }
    }

    void CardDestroy()
    {
        if (TurnManager.turnNumber == 3)
            if (cardNumber == PlayerCard.playerCardNumber)
            {
                Destroy(gameObject);
                TurnManager.turnNumber = 1; 
            }
    }
}
