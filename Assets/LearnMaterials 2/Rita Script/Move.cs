using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : SampleScript
{
    private Vector3 startPos;
    public Vector3 endPos = new Vector3();

    public float speed;

    [SerializeField]
    private bool _key = false;

    private void Start()
    {
        Application.targetFrameRate = 30;
        startPos = transform.position;
    }


    [ContextMenu("Start")]
    public override void Use()
    {
        _key = true;
        transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);

       
    }



    void Update()
    {
        if (_key)
        {
            Use();
        }
    }
}