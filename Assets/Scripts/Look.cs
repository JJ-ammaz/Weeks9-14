using UnityEngine;
using UnityEngine.InputSystem;

public class Look : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        Vector2 direction = mouseWorldPos - (Vector2)transform.position;

        transform.right = direction;
    }
}
