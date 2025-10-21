using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 20f;
    [SerializeField] private float timeDestroy = 0.5f;
    
    void Start()
    {
        Destroy(gameObject, timeDestroy);
    }
    
    void Update()
    {
        MoveBullet();
    }

    void MoveBullet()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}
