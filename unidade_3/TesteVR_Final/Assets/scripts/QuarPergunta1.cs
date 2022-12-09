using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuarPergunta : MonoBehaviour
{
    public GameObject player;

    
    // Start is called before the first frame update
    void Start()
    {

     }
 

    public void OnPointerEnter()
    {

    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {

    }

    // public void OnPointerEnter()
    // {
    //     SetMaterial(true);
    // }

    // /// <summary>
    // /// This method is called by the Main Camera when it stops gazing at this GameObject.
    // /// </summary>
    // public void OnPointerExit()
    // {
    //     SetMaterial(false);
    // }

    public void OnPointerClick()
    {
        player.transform.position = new Vector3(-523.41f, 85.29f, 14.13999f);
 

    }
}
