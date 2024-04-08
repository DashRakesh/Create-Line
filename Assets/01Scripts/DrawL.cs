using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawL : MonoBehaviour
{
    private LineRenderer line;
    private Vector3 PreviouPosition;
    [SerializeField] private GameObject arrow;

    [SerializeField] private float minDistance = 0.1f;
    [SerializeField, Range(0.1f, 2f)] private float width;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        PreviouPosition = transform.position;
        line.positionCount = 1;
        line.startWidth = line.endWidth = width;
    }

    public void StartLine(Vector2 positions)
    {
        line.positionCount = 1;
        line.SetPosition(0, positions);
    } 
    
    public void Update()
    {
      //  Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 currentPosition = arrow.transform.position;
        currentPosition.z = 0;

        if (Vector3.Distance(currentPosition, PreviouPosition) > minDistance)
        {
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, currentPosition);
            PreviouPosition = currentPosition;
        }
    }
}
