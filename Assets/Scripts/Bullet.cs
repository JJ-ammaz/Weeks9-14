using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 10f;

    // timer for despawn
    private float lifeTimer = 0f;
    private float lifeTime = 3f;


    void Start()
    {
        
    }

    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;

        lifeTimer += Time.deltaTime;

        if (lifeTimer >= lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
