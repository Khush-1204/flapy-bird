using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float flap;
    public logic logic;
    public bool redisalive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();

    }

    // Update is called once per frame
    void Update()
    {
        //this sees if the key W is pressed and "==" this cheaks if this happened or not in this case it will see if the W key was pressed
        if (Input.GetKeyDown(KeyCode.W) && redisalive)
        {
            // here it is increasing the velocity to (0,1) then times it by 10. and the statment before will see if the w is pressed if yes then this will happen
            myRigidbody2D.velocity = Vector2.up * flap;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        redisalive = false;
    }
}
