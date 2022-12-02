using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySkill : MonoBehaviour
{
    [SerializeField] int skillXPos;

    public Vector3 cardPos;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        transform.position = new Vector3(skillXPos, -5, 10);
        transform.localScale = new Vector3(2, 2, 0);
    }

    void OnMouseExit()
    {
        transform.position = cardPos;
        transform.localScale = new Vector3(0.9f, 0.9f, 0);
    }
}
