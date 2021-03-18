using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public Vector2 speed = new Vector2(50, 50);
    public Transform player;
    public Vector3 offset;
    bool facingRight = true;
    

    // Start is called before the first frame update
    void Start()
    {
        helloWorld();
    }

    // Update is called once per frame
    void Update()
    {
        
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY);
        movement *= Time.deltaTime;
        transform.Translate(movement);

if(inputX > 0 && !facingRight)
{
 Flip();   
} else if(inputX < 0 && facingRight)
{
    Flip();
}
/*
    Vector3 characterScale = transform.localScale;

    if (inputX < 0)
    {
      characterScale.x = -5;
    }
    if (inputX > 0)
    {
        characterScale.x = 5;
    }

    transform.localScale = characterScale;
    */
    }

    void helloWorld()
    {
        Debug.Log("Hello World");
    }

void Flip()
{
facingRight = !facingRight;
Vector3 theScale = transform.localScale;
theScale.x *= -1;
transform.localScale = theScale;
}

}
