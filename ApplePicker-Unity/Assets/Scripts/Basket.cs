/***
* Created by Cristian Misla
* Created by: Cristian Misla
* Date Created: 1/31/2022
*
* Last Edited By Cristian Misla
* Last Edited: 2/2/2022
* 
* Description: Movement script for the Basket
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }//end of Update()
    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.tag == "Apple")
            {
            Destroy(collidedWith);
        }//end of if()
    }//end of OnCollisionEnter()
}
