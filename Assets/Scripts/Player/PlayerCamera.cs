using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 distance = new Vector3(0, 0, -10);

    private void Update()
    {
        transform.position = player.position + distance;
    }
}
