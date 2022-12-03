using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaticleCtrl : MonoBehaviour
{
    public Camera cam;
    public GameObject[] ParticlePrefabs;
    //public ParticleSystem[] ParticleCom;

    [SerializeField]
    Vector2 MouseVector;

    [SerializeField]
    Transform MousePos;

    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();

        //for(int i = 0; i < ParticlePrefabs.Length; i++)
        //{
        //    ParticleCom[i] = GameObject.Find(ParticlePrefabs[i].name).GetComponent<ParticleSystem>();
        //}
    }

    void Update()
    {
        MouseVector = Input.mousePosition;
        MouseVector = cam.ScreenToWorldPoint(MouseVector);

        transform.position = MouseVector;
        MousePos = transform;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject Click = Instantiate(ParticlePrefabs[0], MousePos) as GameObject;
            Click.transform.SetParent(null);
        }
    }
}
