using UnityEngine;

public class PlayerCollsion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyBullet"))
        {
            Player player = collision.GetComponent<Player>();
            player.TakeDamage(10f);
        }
    }
}
