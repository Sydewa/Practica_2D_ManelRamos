using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]private float duration;
    [SerializeField]private float magnitude;
    
    public IEnumerator Shake()
    {
        Vector3 originalPos = transform.position;
        float elapsed = 0;

        /*while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            transform.position = new Vector3(x + originalPos.x, y + originalPos.y, transform.position.z);
            elapsed += Time.deltaTime;
            yield return null;
        }*/

        for(float i = elapsed; i < duration; i += Time.deltaTime)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            transform.position = new Vector3(x + originalPos.x, y + originalPos.y, transform.position.z);
            yield return null;
        }

        //yield return new WaitForSeconds(1f); Esto se usa para hacer esperar al script
    }

}
