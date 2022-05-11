using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleItem : MonoBehaviour
{
    private Renderer rend;
    [Range(0,1)]
    public float currentValue;
    public UnityEvent onDestroyObstacle;
    float color=1;

    private void OnMouseDown()
    {
        GetDamage(0.1f);

    }
    public void GetDamage(float value)
    {
        
        currentValue = currentValue - value;
        if (currentValue < 1) 
        {
            ColorUpdate();
            
        }
        

    }
    public void ColorUpdate()
    {
          
       rend.material.color = new Color(1,color,color);
        color = color - 0.1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        onDestroyObstacle.AddListener(() => Destroy(gameObject));
    }

    private void Update()
    {
        if (currentValue <= 0)
        {
            onDestroyObstacle.Invoke();
        }
        
    }
    // Update is called once per frame

}
