using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -14f, 14f), Mathf.Clamp(transform.position.y, -7f, 7f), transform.position.z);
    }
}
