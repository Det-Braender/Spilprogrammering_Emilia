using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float space = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + space, transform.position.z);
    }
    public void moveDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - space, transform.position.z);
    }
}
