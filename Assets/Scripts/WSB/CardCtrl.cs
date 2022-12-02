using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCtrl : MonoBehaviour
{
    public GameObject[] Card = new GameObject[5];
    public GameObject[] CardText = new GameObject[5];
    public float rotSpeed = 1000f;
    public bool turn = false;

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
            if(Card[0].transform.rotation.z < 100)
            {
                Card[0].transform.Rotate(new Vector3(0, 0, rotSpeed * Time.deltaTime));
            }
            else
            {
                Card[0].transform.Rotate(new Vector3(0, 0, 0));
                Card[0].transform.rotation = Quaternion.identity;
                turn = false;
            }    
        }
    }
}
