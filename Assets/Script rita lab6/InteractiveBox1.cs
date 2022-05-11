using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveBox1 : MonoBehaviour
{
    public InteractiveBox1 next;
    public void AddNext(InteractiveBox1 box)
    {
        next = box;
    }

    // Update is called once per frame
    public void Line()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position,  transform.forward, Color.red);
    }
    private void Update()
    {
        Line();
    }
}