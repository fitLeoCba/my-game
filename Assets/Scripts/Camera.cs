using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Leo;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Leo.transform.position.x;
        transform.position = position;
    }
}
