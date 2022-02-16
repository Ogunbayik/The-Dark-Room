using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private Vector3 direction;
    [SerializeField] private Player firePoint;
    // Start is called before the first frame update
    void Start()
    {
        firePoint = FindObjectOfType<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        direction = transform.position - firePoint.transform.position;
        transform.Translate(direction * speed * Time.deltaTime);
    }

}
