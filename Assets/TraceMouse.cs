﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TraceMouse : MonoBehaviour
{
    public LayerMask layer;
    public Vector3 mousePosition;
    public Vector3 hitPoint;
    public bool isHit;
    public Ray ray;
    public RaycastHit hitData;
    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            mousePosition = Input.mousePosition;
            ray = Camera.main.ScreenPointToRay(mousePosition);

            if (Physics.Raycast(ray, out hitData, 1000, layer))
            {
                isHit = true;
                transform.position = hitData.point;
                hitPoint = hitData.point;
            }
            else
            {
                isHit = false;
            }

        }

    }
    public float rayLenght = 1000f;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(ray.origin, ray.direction * rayLenght);
    }


}

