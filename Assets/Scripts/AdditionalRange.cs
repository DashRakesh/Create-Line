using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalRange : MonoBehaviour
{
    public LineRenderer linee;
    
 //   public Transform pos1;
 //   public Transform pos2;
    public List<Vector3> CheckedPositions;

    void Start()
    {
        linee = GetComponent<LineRenderer>();
        Vector3[] positions = new Vector3[3];

        linee.positionCount = 1;
    }

    void Update()
    {
       // linee.SetPositions(0, pos1.transform.position);
        //   lin.SetPosition(0, pos2.transform.position);
    }
}
