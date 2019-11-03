using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRigidbody : MonoBehaviour
{
    public float mass = 1;
    public float velocityX = 0;

    public void UpdateMotion()
    {
        transform.Translate(new Vector3(velocityX * 0.00003f, 0, 0));
    }
}
