using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sometimes, ball goes out of walls.
        if(gameObject.transform.position.x > 25 || gameObject.transform.position.x < -25)
        {
            Destroy(gameObject);
        }
        else if(gameObject.transform.position.z > 25 || gameObject.transform.position.z < -25)
        {
            Destroy(gameObject);
        }
        else if(gameObject.transform.position.y <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
