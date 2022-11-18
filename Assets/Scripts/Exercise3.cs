using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    private Vector2 W;
    private int currentPositionX;
    private int currentPositionY;


    private void Update()
    {


        if (currentPositionY < 2)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                W = new Vector2(transform.position.x, transform.position.y + 140);
                this.transform.position = W;
                currentPositionY++;
            }
        }
       
        if(currentPositionY > -2)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                W = new Vector2(transform.position.x, transform.position.y + -140);
                this.transform.position = W;
                currentPositionY--;
            }
        }
        

        if(currentPositionX < 2)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Vector3 W = new Vector2(transform.position.x + 140, transform.position.y);
                this.transform.position = W;
                currentPositionX++;
            }
        }

        if (currentPositionX > -2)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Vector3 W = new Vector2(transform.position.x + -140, transform.position.y);
                this.transform.position = W;
                currentPositionX--;
            }
        }
        
    }
}
