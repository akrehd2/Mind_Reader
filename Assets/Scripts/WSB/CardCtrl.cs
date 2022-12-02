using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCtrl : MonoBehaviour
{
    public GameObject[] Card = new GameObject[5];
    public GameObject[] CardText = new GameObject[5];
    public float rotSpeed = 100f;
    public bool turn = false;
    public float timer = 0f;
    public float tick = 1f;

    void Update()
    {
        for(int i =0;i<=4;i++)
        {
            Card[i] = GameObject.Find("Card"+(i + 1).ToString());
        }
        for (int i = 0; i <= 4; i++)
        {
            CardText[i] = GameObject.Find((i + 1).ToString());
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && !turn)
        {
            turn = true;
            Card[0].transform.Rotate(new Vector3(0, 0, rotSpeed * Time.deltaTime));
        }

        if(turn)
        {
            if (timer <= 3.6f)
            {
                timer += tick * Time.deltaTime;
                Card[0].transform.Rotate(new Vector3(0, 0, rotSpeed * Time.deltaTime));
            }
            else
            {
                Card[0].transform.Rotate(new Vector3(0, 0, 0));
                turn = false;
                timer = 0f;
            }
        }
    }
}
