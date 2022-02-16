using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public GameObject cam;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float speed; 
    [SerializeField] private float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameIsOver == false)
        {
            Movement();
            Fire();
        }
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            cam.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
            cam.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        Vector3 direction = transform.right * horizontalInput + transform.forward * verticalInput;

        controller.Move(direction);

    }

    void Fire()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        }
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<GameManager>().gameIsOver = true;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
