using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    public GameObject player;
    private Vector3 v3;

    void Update()
    {
        Vector2 pos = player.transform.position;
        v3.z = -30f; //la posicion z que tengas tu
        transform.position = pos;
        transform.position += v3;
    }
}
