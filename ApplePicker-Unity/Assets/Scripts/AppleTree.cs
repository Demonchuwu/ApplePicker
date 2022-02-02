/***
* Created by Cristian Misla
* Created by: Cristian Misla
* Date Created: 1/31/2022
*
* Last Edited By Cristian Misla
* Last Edited: 2/2/2022
* 
* Description: Movement script for the AppleTree
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{

    /*** VARIABLES ***/
    [Header("SET IN INSPECTOR")]
    public float speed = 1f; //Tree speed
    public float leftAndRightEdge = 15f; //Distance where the tree turns around
    public GameObject applePrefab; //Prefab for instantiating apples
    public float secondsBetweenAppleDrops = 1f; //Time between each apple drop
    public float chanceToChangeDirections = 0.1f; //Chance to change directions


    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f); //Calls DropApple() 
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    } //end DropApple()

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position; //Records the current position
        pos.x += speed*Time.deltaTime; //Adds speed to the x position
        transform.position = pos; //Apply the position value

        //Change Directions
        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //Set speed to postive 
        }
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //Set speed to negative
        }//end Change Directions

    }//end Update() 

    //FixedUpdate is called on fixed intervals (50 times per second)
    private void FixedUpdate()
    {
        //Test Chance of Direction Change
        if(Random.value < chanceToChangeDirections)
        {
            speed *= -1; //Change Directions
        }
    }//end FixedUpdate()

}


