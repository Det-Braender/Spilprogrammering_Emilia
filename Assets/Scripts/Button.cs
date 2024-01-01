using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private bool hasPressed=false;
    [SerializeField] //makes it visible in the inspector.
    public GameObject wall;
    [SerializeField]
    GameObject bc;
    public AudioSource sliding;
    public float min = 3.0f;
    public float max = 6.0f;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPressed)
        {
            if (wall.transform.position.y < max)
            {
                wall.transform.Translate(0f, Time.deltaTime*speed, 0f);
            }
        } else
        {
            if (wall.transform.position.y > min)
            {
                wall.transform.Translate(0f, - speed *Time.deltaTime , 0f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // collided = true;
        if (collision.gameObject.tag=="Player") 
        {
            if (!hasPressed) 
            {
                bc.transform.position = new Vector3(bc.transform.position.x, bc.transform.position.y - 0.06f, bc.transform.position.z);
                hasPressed = true;
               
                //wall.transform.position = new Vector3(wall.transform.position.x, wall.transform.position.y + 3.0f, wall.transform.position.z);
               sliding.Play();
               Invoke("CloseDoor", 7.0f);
            }
                
            Debug.Log("player hit button");
            
        }
       
    }

    private void CloseDoor()
    {
        bc.transform.position = new Vector3(bc.transform.position.x, bc.transform.position.y + 0.06f, bc.transform.position.z);
        sliding.Play();
        hasPressed =false;
    }

   
   /* private void OnCollisionExit2D(Collision2D collision)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.06f, transform.position.z);
        wall.moveDown();
        hasPressed=false;
    }*/
}
