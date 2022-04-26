using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone : SampleScript
{
    public Transform startPosition;

    [SerializeField]
    private int step;
    public Vector3 whereToSpawn;


    private float localPosition;

    public GameObject CloneCube;

    [Range(0, 10)]
    public int Counter;

    [Min(0)]
    public float CoolDown;


    [SerializeField]
    private bool _key;

    private void Start()
    {

    }
    void Repeat()
    {
        Counter--;
        if (Counter != 0)
        {
            StartCoroutine(SpawnCD());
        }
    }
    IEnumerator SpawnCD()
    {


        whereToSpawn = new Vector3(localPosition, transform.position.y, transform.position.z);
        Instantiate(CloneCube, whereToSpawn, Quaternion.identity);
        localPosition += step;
        yield return new WaitForSeconds(CoolDown);
        Repeat();

    }

    [ContextMenu("start")]
    public override void Use()
    {
        StartCoroutine(SpawnCD());
    }

    void Update()
    {


    }
}