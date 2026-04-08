using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public GameObject singleBullet;
    public GameObject spreadBullet;
    public GameObject rapidBullet;
    public bool PistolActive = false;
    public bool ShotgunActive = false;
    public bool RifleActive = false;
    
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
            if (PistolActive)
            {
                Instantiate(singleBullet, transform.position, transform.rotation);
            }
            if (ShotgunActive)
            {
                Instantiate(spreadBullet, transform.position, transform.rotation);
                Instantiate(spreadBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
                Instantiate(spreadBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
                Instantiate(spreadBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
                Instantiate(spreadBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
                Instantiate(spreadBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
                Instantiate(spreadBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
                Instantiate(spreadBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
                Instantiate(spreadBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
                Instantiate(spreadBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
                Instantiate(spreadBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
                Instantiate(spreadBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
            }
            if (RifleActive)
            {

            }
        }
    }
}
