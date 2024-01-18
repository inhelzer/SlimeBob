using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float maxSpeed;
    [SerializeField] float speed;
    int clickCounter = 0;
    float delay = 1;
    float flipTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    private void OnMouseDown()
    {
        clickCounter++;
        if(clickCounter %2 == 1)
        {
            speed = maxSpeed;
        }
        if (clickCounter % 2 == 0)
        {
            speed = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Bad")
        {
            Destroy(gameObject);
        }

        if((other.gameObject.tag == "Flip") && (Time.time - flipTime >= delay)) 
        {
            flipTime = Time.time;
            speed = speed * (-1);
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Level")
        {
            transform.rotation = Quaternion.identity;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            
        }
    }
}
