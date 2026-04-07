using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{

    public float speed = 5f;
    private Vector2 movement;

    void Start()
    {
        
    }

    void Update()
    {
        // moves player adjustable speed 
        transform.position += (Vector3)movement * speed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
}
