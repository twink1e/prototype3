﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBackground : MonoBehaviour
{
    private Vector3 initialPos;
    private double offset;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        offset = GetComponent<BoxCollider>().size.x / 2.0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= initialPos.x - offset) {
            transform.position = initialPos;
        }
    }
}
