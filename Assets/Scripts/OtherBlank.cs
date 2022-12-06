using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBlank : MonoBehaviour
{
    public Vector3 target;
    public Vector3 CardPos;

    public static bool cardDelete = false;

    void Start()
    {
        target = CardPos;
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);

        if(TurnManager.turnCount == 3)
        {
            if (gameObject.transform.position == new Vector3(-8, 0, 0) || gameObject.transform.position == new Vector3(-16, 0, 0))
            {
                Destroy(gameObject);
            }
        }
    }
}
