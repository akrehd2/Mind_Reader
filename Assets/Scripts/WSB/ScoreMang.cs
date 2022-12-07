using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMang : MonoBehaviour
{
    public GameObject[] obj = new GameObject[4];

    public static int remainCard = 5;

    private void Start()
    {
        remainCard = 5;
    }

    void Update()
    {
        Debug.Log(remainCard);
        if (Count.myScore >= 3)
        {
            obj[0].SetActive(true);
            obj[1].SetActive(true);
        }
        else if (Count.otherScore >= 3)
        {
            obj[0].SetActive(true);
            obj[3].SetActive(true);
        }
        else if (Count.otherScore < Count.myScore && remainCard == 0)
        {
            obj[0].SetActive(true);
            obj[1].SetActive(true);
        }
        else if (Count.otherScore > Count.myScore && remainCard == 0)
        {
            obj[0].SetActive(true);
            obj[3].SetActive(true);
        }
        else if (Count.otherScore == Count.myScore && remainCard == 0)
        {
            obj[0].SetActive(true);
            obj[2].SetActive(true);
        }
    }
}
