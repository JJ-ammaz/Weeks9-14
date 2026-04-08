using UnityEngine;
using UnityEngine.InputSystem;

public class ShotgunTrial : MonoBehaviour
{

    public GameObject bulletPrefab;

    void Start()
    {

        Debug.Log("start");
    }

    void Update()
    {
        Debug.Log("a bajillion");
}

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            Instantiate(bulletPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
            Instantiate(bulletPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
            Instantiate(bulletPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
            Instantiate(bulletPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
            Instantiate(bulletPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
            Instantiate(bulletPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
            Instantiate(bulletPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
            Instantiate(bulletPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
            Instantiate(bulletPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
            Instantiate(bulletPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
            Instantiate(bulletPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-10, 10)));
        }
    }
}
