using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWithMouse : MonoBehaviour
{
    private LineRenderer line;
    private Vector3 previousPosition;

    [SerializeField] private float minDistance = 0.1f;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        previousPosition = transform.position;
    }

    private void UpdateLine()
    {
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        currentPosition.z = 0;
    }
}
