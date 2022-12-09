using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Interpolacao : MonoBehaviour
{
    public Vector3 positionToMoveTo;
    // Start is called before the first frame update
    void Start()
    {
        positionToMoveTo = transform.position;
        positionToMoveTo.x += -70;
        positionToMoveTo.y += 2;
        positionToMoveTo.z += 10;
        StartCoroutine(LerpPosition(positionToMoveTo, 5));
        LerpPosition(positionToMoveTo, 2.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator LerpPosition(Vector3 targetPosition, float duration){
        float time = 0;
        Vector3 startPosition = transform.position;
        while (time < duration){
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    } 
}
