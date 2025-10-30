using UnityEngine;

public class Explosion : MonoBehaviour
{
   [SerializeField] private float damage = 25f;
   private void OnCollisionEnter2D(Collision2D collision)
   {
      Player player = collision.gameObject.GetComponent<Player>();
      Enemy enemy = collision.gameObject.GetComponent<Enemy>();

      if (collision.gameObject.CompareTag("Player") && player != null)
      {
         player.TakeDamage(damage);
      }

      if (collision.gameObject.CompareTag("Enemy") && enemy != null)
      {
         enemy.TakeDamage(damage);
      }
   }
   public void DestroyExplosion()
   {
      Destroy(gameObject);
   }
}
