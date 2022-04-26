using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    float x;
    private void Update()
    {
        x +=Time.deltaTime * 10;
        transform.rotation = Quaternion.Euler(x, 0, 0);
    }

}
