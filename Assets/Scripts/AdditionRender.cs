using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionRender : MonoBehaviour
{
    public LineRenderer lin;
    public Transform pos1;
   // public Transform pos2;

     void Start()
    {
        lin.positionCount = 1;
    }

    void Update()
    {
        lin.SetPosition(0, pos1.transform.position);
     //   lin.SetPosition(0, pos2.transform.position);
    }
}
