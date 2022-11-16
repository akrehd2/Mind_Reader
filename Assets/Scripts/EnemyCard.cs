using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCard : MonoBehaviour
{
    public int number;
    public int ecoNumber;
    public List<int> enemyNoUseNumber = new List<int>()
    { 1,2,3,4,5};

    public List<int> ecoNoUseNumber = new List<int>()
    { 1,2,3,4,5};

    public static int enemyCardNumber = 0;
    public static int ecoN = 0;
    public int eNSize = 5;
    public int ecoNSize = 5;

    void Start()
    {
        
    }

    void Update()
    {
        if (TurnManager.turnPoint == -1 && enemyCardNumber==0)
        {
            RandomNumber();
        }
        number = enemyCardNumber;
        ecoNumber = ecoN;
        RandECardOffNumber();
    }

    void RandomNumber()
    {
        int i = Random.Range(0, eNSize);
        enemyCardNumber = enemyNoUseNumber[i];
        enemyNoUseNumber.RemoveAt(i);
        eNSize -= 1;
    }

    void RandECardOffNumber()
    {
        if (TurnManager.turnPoint == -1 && ecoN == 0)
        {
            int i = Random.Range(0, ecoNSize);
            ecoN = ecoNoUseNumber[i];
            ecoNoUseNumber.RemoveAt(i);
            ecoNSize -= 1;
        }
    }
}
