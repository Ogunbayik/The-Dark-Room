using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : EnemyBase
{
   

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        Die();
    }


    public override void Movement()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    public override void SetHealth()
    {
        health--;
    }
    public override void Die()
    {
        base.Die();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            SetHealth();
        }
    }
}
