using UnityEngine;
using System.Collections;

public class BillBoard : MonoBehaviour
{
    public Camera cameraToLookAt;

    void Update()
    {
        transform.LookAt(cameraToLookAt.transform);
    }
}