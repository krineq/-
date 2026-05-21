using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private int damage = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth hp = other.GetComponent<PlayerHealth>();

        if (hp != null)
        {
            hp.TakeDamage(damage);
        }
    }
}