using UnityEngine;
using UnityEngine.InputSystem;

public class Look : MonoBehaviour
{
    private Vector2 mouseWorldPos;


    void Start()
    {
        
    }

    void Update()
    {
        
        Vector2 direction = mouseWorldPos - (Vector2)transform.position;

        transform.up = direction;
        //so its looking the right way
        transform.Rotate(0, 0, 90); 
    }

    public void OnPoint(InputAction.CallbackContext context)
    {
        //big helps to this https://slate.sheridancollege.ca/d2l/le/content/1461390/viewContent/18777907/View
        // the lign basically is pulling the context from the ui pointer instead of how we usually do it and the camer.main.screenworld is in refrence to where the mouse is on the "camera"
        mouseWorldPos = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
    }
}
