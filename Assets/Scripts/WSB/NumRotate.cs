using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumRotate : MonoBehaviour
{
    public GameObject[] Card = new GameObject[5];
    public GameObject GM;
    public CardCtrl ctrl;
    Color color;

    private void Start()
    {
        GM = GameObject.Find("GameManeger");
        ctrl = GM.GetComponent<CardCtrl>();
    }
    void Update()
    {
        for (int i = 0; i <= 4; i++)
        {
            Card[i] = GameObject.Find("Card" + (i + 1).ToString());
        }

        if (gameObject.name == "1")
        {
            gameObject.transform.rotation = Quaternion.Euler(0, Card[0].transform.rotation.z * 200, 0);
        }

        if(ctrl.timer >= 1.8f)
        {
            color.a = 0f;
        }
        else
        {
            color.a = 1f;
        }
    }
}
