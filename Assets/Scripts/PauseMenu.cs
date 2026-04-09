using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public UnityEvent onPause;
    public UnityEvent onUnpause;

    private bool isPaused = false;


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            //basic toggle on and off for pausing thats it. turns off all the scripts not the player (cause it has the input system)
            if(isPaused == false)
            {
                isPaused = true;
                onPause.Invoke();
            }
            else
            {
                isPaused=false;
                onUnpause.Invoke();


            }


        }
    }
}
