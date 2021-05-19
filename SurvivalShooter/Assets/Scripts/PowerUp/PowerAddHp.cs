using UnityEngine;
using System.Collections;

public class PowerAddHp : MonoBehaviour
{
    public int healthIncrease = 50;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            PlayerHealth ph = collision.collider.GetComponent<PlayerHealth>();
            ph.currentHealth += healthIncrease;
            ph.TakeDamage(0);
            Destroy(gameObject);
        }
    }
}
