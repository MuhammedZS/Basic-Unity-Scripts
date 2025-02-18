using UnityEngine;

public class Target : MonoBehaviour
{
    public AudioSource src;
    public GameObject destroyedCrate;
    public float health = 50f;
    public void TakeDamage (float amount)
    {
        health -= amount;
        if(health<= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Instantiate(destroyedCrate, transform.position, transform.rotation);
            Destroy(gameObject);
            src.Play();
    }
}