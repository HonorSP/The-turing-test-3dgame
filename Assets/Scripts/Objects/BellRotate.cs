﻿using UnityEngine;

/**
 * BellRotate - Rotates a bell.
 */


public class BellRotate : MonoBehaviour
{
    public float rotateSpeed = 1.25f;

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0f, 0f, rotateSpeed));
    }
}
