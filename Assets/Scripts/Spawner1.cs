using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject platformPrefab;

    public GameObject previousPlatform;
    public GameObject mario;
    [Range(0f, 25f)]
    public float xRange = 8;
    [Range(0f, 25f)]
    public float yRange = 5;

    // Start is called before the first frame update
    void Start()
    {
        float randomFloat = Random.Range(-1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //if(Vector3.Distance(mario.transform.position, previousPlatform.transform.position) < 10)
        if(previousPlatform.transform.position.x - mario.transform.position.x < 10)
        {
            
            Vector3 newPosition = previousPlatform.transform.position + new Vector3(20 + Random.Range(-xRange, xRange), Random.Range(-yRange,yRange), 0);

            previousPlatform = Instantiate(platformPrefab, newPosition, Quaternion.identity);
        }
    }
}
