/***
* Created by Cristian Misla
* Created by: Cristian Misla
* Date Created: 1/31/2022
*
* Last Edited By Cristian Misla
* Last Edited: 2/7/2022
* 
* Description: Script for the Apple Prefab
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f; //

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
        }
    }
}
