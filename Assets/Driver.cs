﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] GameObject crew;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal2"));


        crew.transform.Translate(transform.forward * Input.GetAxis("Vertical")*speed, Space.Self);

        //Debug.Log(transform.eulerAngles.y);
        GM._instance.setAngleText(2, transform.eulerAngles.y);

    } 
}
