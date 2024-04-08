using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
  // here all the points we need to follow
  [SerializeField]  Transform[] points;
// for movement of the enemy character through path points
  [SerializeField]  private float moveSpeed;
 // index number of  paths help for follow
  [SerializeField]  private int pointIndex;

    private void Start()
    {
        transform.position = points[pointIndex].transform.position;
    }
    private void Update()
    {
        if(pointIndex <= points.Length - 1)
        {
           
            transform.position = Vector2.MoveTowards(transform.position, points[pointIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == points[pointIndex].transform.position)
            {
                pointIndex += 1;
            }
            if(pointIndex == points.Length)
            {
                pointIndex = 0;
            }
        }
    }
}
