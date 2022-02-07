/***
* Created by Cristian Misla
* Created by: Cristian Misla
* Date Created: 1/31/2022
*
* Last Edited By Cristian Misla
* Last Edited: 2/7/2022
* 
* Description: Game Manager for ApplePicker
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("SET IN INSPECTOR")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;


    // Start is called before the first frame update
    void Start()
    {
       for(int i=0; i<numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }//end of for()
    }//end Start()

    // Update is called once per frame
    void Update()
    {
    }//end Update()

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGo in tAppleArray)
        {
            Destroy(tGo);
        }//end foreach
    }//end AppleDestroyed()

}
