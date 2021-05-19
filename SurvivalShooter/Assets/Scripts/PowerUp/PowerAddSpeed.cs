using UnityEngine;
using System.Collections;

public class PowerAddSpeed : MonoBehaviour
{
    public int movementIncrease = 2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            PlayerMovement pm = collision.collider.GetComponent<PlayerMovement>();
            pm.speed += movementIncrease;
            Destroy(gameObject);
        }
    }
}
