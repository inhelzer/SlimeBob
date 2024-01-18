using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonLift : MonoBehaviour
{
    [SerializeField] GameObject lift;
    [SerializeField] float yMaxSpeed;
    float ySpeed = 0;
    [SerializeField] float xMaxSpeed;
    float xSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lift.transform.Translate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, 0);
    }

    private void OnMouseDown()
    {
        ySpeed = yMaxSpeed;
        xSpeed = xMaxSpeed;
    }

    private void OnMouseUp()
    {
        ySpeed = 0;
        xSpeed = 0;
    }
}
