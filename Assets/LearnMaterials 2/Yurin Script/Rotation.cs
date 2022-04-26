using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : SampleScript
{
    float x;
     public int speed;

    public override void Use()
    {

        Transform();
    }

    public void Transform()
    {
        x +=Time.deltaTime * speed;
        transform.rotation = Quaternion.Euler(x, 0, 0);
    }
    private void Update()
    {
        Use();
    }
}
