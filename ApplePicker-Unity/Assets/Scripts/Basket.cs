/***
* Created by Cristian Misla
* Created by: Cristian Misla
* Date Created: 1/31/2022
*
* Last Edited By Cristian Misla
* Last Edited: 2/8/2022
* 
* Description: Movement script for the Basket
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//using UI libraries

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;
    //public GameObject score; Another way to call an object, but it doesn't work this way due to the code being on an object that isn't placed yet.



    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter"); //Score game object
        scoreGT = scoreGO.GetComponent<Text>(); //The text component of the score GO 
        scoreGT.text = "0"; //Set the text property
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

            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();

            if(score > HighScore.score)
            {
                HighScore.score = score;
            }

        }//end of if(collidedWith.tag == "Apple")
    }//end of OnCollisionEnter()
}
