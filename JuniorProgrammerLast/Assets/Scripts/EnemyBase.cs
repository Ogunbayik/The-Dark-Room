using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    public float speed;
    public int health;
    public int scoreToAdd;
    public Player player;
    public Rigidbody enemyRb;
    public ParticleSystem explosionParticle;

    public abstract void Movement();
    public abstract void SetHealth();

    public virtual void Die()
    {
        if (health <= 0)
        {
            FindObjectOfType<GameManager>().gameScore += scoreToAdd;
            ParticleSystem explosion = (ParticleSystem)Instantiate(explosionParticle, this.gameObject.transform.position, Quaternion.identity);
            Destroy(explosion.gameObject, 2f);
            Destroy(this.gameObject);
        }
    }



}
