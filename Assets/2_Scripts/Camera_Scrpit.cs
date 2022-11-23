using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Scrpit : MonoBehaviour
{
    [SerializeField]Transform cameraTarget;
    [SerializeField]Vector3 offset;

    void Update()
    {
        Vector3 desiredPos = new Vector3(cameraTarget.position.x + offset.x, cameraTarget.position.y + offset.y, offset.z);
        transform.position = new Vector3(desiredPos.x, desiredPos.y, desiredPos.y);
    }
}
