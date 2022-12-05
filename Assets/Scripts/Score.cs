using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text ScoreN;
    [SerializeField] int ScoreP;

    void Start()
    {
        ScoreN = gameObject.GetComponent<Text>();
    }

    
    void Update()
    {
        if(ScoreP==1)
        {
            int i = Count.myScore;
            ScoreN.text = i.ToString();
        }

        if (ScoreP == 2)
        {
            int i = Count.otherScore;
            ScoreN.text = i.ToString();
        }
    }
}
