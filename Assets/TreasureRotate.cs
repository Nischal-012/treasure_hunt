using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TreasureRotate : MonoBehaviour
{
    private float speed = 2;
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
    }
}
