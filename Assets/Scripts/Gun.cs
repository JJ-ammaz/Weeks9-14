using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public GameObject singleBullet;
    public GameObject spreadBullet;
    public GameObject rapidBullet;
    public bool SingleShotActive = false;
    public bool SpreadShotActive = false;
    public bool RapidShotActive = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (RapidShotActive)
        {
            Instantiate(rapidBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-2, 2)));
        }

        if (context.performed == true)
        {
            if (SingleShotActive)
            {
                Instantiate(singleBullet, transform.position, transform.rotation);
            }
            if (SpreadShotActive)
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

        }
    }
}
