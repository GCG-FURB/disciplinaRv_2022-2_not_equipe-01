using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject player;
    public int val1;
    public Vector3 positionToMoveTo;
    
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

        positionToMoveTo = transform.position;
        positionToMoveTo.x += -35;
        positionToMoveTo.y += 3;
        positionToMoveTo.z += -15;
        StartCoroutine(LerpPosition(positionToMoveTo, 5));
        LerpPosition(positionToMoveTo, 2.0f);

    }

    public IEnumerator LerpPosition(Vector3 targetPosition, float duration){
        float time = 0;
        Vector3 startPosition = transform.position;
        while (time < duration){
 
            player.transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
    } 
}
