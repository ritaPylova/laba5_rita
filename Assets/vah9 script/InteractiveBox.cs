using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveBox : MonoBehaviour
{
    public InteractiveBox next;
    public void AddNext(InteractiveBox box)
    { 
        if (next is null)
        next = box;

    }

    // Update is called once per frame
    public void Line()

    {
        Ray ray = new Ray(transform.position, next.transform.position - transform.position);
        Debug.DrawRay(transform.position, next.transform.position - transform.position, Color.red);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if ( hit.collider.gameObject.GetComponent<ObstacleItem>())
            {
                hit.collider.gameObject.GetComponent<ObstacleItem>().GetDamage(Time.deltaTime);
            }

        }
    }
    private void Update()
    {
        Line();
    }

}

