using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{

    public GameObject bulletPrefab;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
