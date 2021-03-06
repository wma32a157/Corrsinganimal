using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class RecordMouse : MonoBehaviour
{
    public LayerMask checkLayerMask;
    public int layerTest1;
    public int layerTest2;
    public int layerTest3;
    
    private void OnMouseEnter()
    {
        print(transform.GetPath() + "OnMouseEnter 마우스 위에있음");
    }
    private void OnMouseOver()
    {
        print(transform.GetPath() + "OnMouseOver 마우스 위에 있음");
    }
    private void OnMouseDown()
    {
        print(transform.GetPath() + "OnMouseDown 마우스 다운");
    }
    private void OnMouseUp()
    {
        print(transform.GetPath() + "OnMouseUp 마우스 업");
    }

    private void OnMouseExit()
    {
        print(transform.GetPath() + "OnMouseExit 마우스 벗어남");
    }
    private void OnMouseDrag()
    {
        print(transform.GetPath() + "OnMouseDrag 마우스 드래그중");

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        layerTest1 = checkLayerMask;
        layerTest2 = 1 << checkLayerMask;
        layerTest3 = LayerMask.NameToLayer("UI");

        RaycastHit hitData;
        if (Physics.Raycast(ray, out hitData, 1000, checkLayerMask))
        {
            transform.position = hitData.point;
        }
    }
}

