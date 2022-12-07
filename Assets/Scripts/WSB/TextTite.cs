using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTite : MonoBehaviour
{
    public GameObject over;

    void Update()
    {
        if (over.active == false)
        {
            gameObject.SetActive(false);
        }
    }
}
