using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWthMouse : MonoBehaviour
{
    [SerializeField] private float minDistance = 0.1f;
    private LineRenderer line;
    private Vector3 previouPosition;

     void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 1;
        previouPosition = transform.position;
    }

     void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPos.z = 0f;

            if(Vector3.Distance(currentPos, previouPosition) > minDistance)
            {
                if(previouPosition == transform.position)
                {
                    // it means first point
                    line.SetPosition(0, currentPos);
                }
                else
                {
                    line.positionCount++;
                    line.SetPosition(line.positionCount - 1, currentPos);
                }
                
                previouPosition = currentPos;
            }
        }
    }
}
