using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SndStop : MonoBehaviour
{
    public AudioSource snd;

    private void Start()
    {
        snd = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown("["))
        {
            snd.volume -= 0.1f;
        }
        else if (Input.GetKeyDown("]"))
        {
            snd.volume += 0.1f;
        }
    }
}
