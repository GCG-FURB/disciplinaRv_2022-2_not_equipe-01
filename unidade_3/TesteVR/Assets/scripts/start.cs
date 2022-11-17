using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject player;
    public GameObject mapa;
    public GameObject livro;
    
    // Start is called before the first frame update
    void Start()
    {
        mapa.SetActive(false);
        livro.SetActive(true);
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
        mapa.SetActive(true);
        livro.SetActive(false);

        player.transform.position = new Vector3(-491.851f, 90.755f,  34.671f);
    }
}
