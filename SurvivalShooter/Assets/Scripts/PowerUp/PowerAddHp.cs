using UnityEngine;
using System.Collections;

public class PowerAddHp : MonoBehaviour
{
    public int healthIncrease = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            PlayerHealth ph = collision.collider.GetComponent<PlayerHealth>();
            ph.currentHealth += healthIncrease;
            Destroy(gameObject);
        }
    }
}
