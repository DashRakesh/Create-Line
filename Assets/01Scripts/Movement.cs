using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // for rurning
    public float Speed = 3.5f;

    // for rotation
    public float currentRotation;
    public float rotationSensitivity = 50.0f;

    // mouse input
    private Vector3 pointInWorld;
    private Vector3 mousePosition;
    private Vector3 direction;
    private float radius;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        INPUTROTATION();
       // MouseRotationArrow();

    }
    void MouseRotationArrow()
    {
        Ray ray = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit, 1000.0f);

        mousePosition = new Vector3(hit.point.x, hit.point.y, 0);
        direction = mousePosition - transform.position;
        direction.z = 0;

        pointInWorld = direction.normalized * radius + transform.position;
        transform.LookAt(pointInWorld);
    }

     void INPUTROTATION()
    {
        if (Input.GetKey(KeyCode.A))
        {
            currentRotation += rotationSensitivity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            currentRotation -= rotationSensitivity * Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
       MoveForward();
       Rotation();
    }
    void MoveForward()
    {
        // transform.position += transform.forward * Speed * Time.fixedDeltaTime;
        transform.position = transform.position + transform.forward * Speed * Time.deltaTime;
    }
    void Rotation()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, currentRotation);
    }
   
}
