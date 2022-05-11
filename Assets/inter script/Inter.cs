using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inter : MonoBehaviour
{

    public GameObject Prefab;

    private InteractiveBox _currentBox;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.tag == ("InteractivePlane"))
                {
                    Instantiate(Prefab, (hit.point + hit.normal) - new Vector3(0, 0.5f, 0), Quaternion.identity);
                }

                if (hit.collider.gameObject.GetComponent<InteractiveBox>())
                {

                    if (_currentBox != hit.collider.gameObject.GetComponent<InteractiveBox>() && _currentBox)
                    {
                        hit.collider.gameObject.GetComponent<InteractiveBox>().AddNext(_currentBox);
                        _currentBox = null;
                    }
                    else
                    {
                        _currentBox = hit.collider.gameObject.GetComponent<InteractiveBox>();
                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.GetComponent<InteractiveBox>())
                {
                    Destroy(hit.collider.gameObject);
                }

            }
        }
    }
}
