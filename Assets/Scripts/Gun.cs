using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{

    //the cherry on top the invoke for audio
    public UnityEvent onSemiFire;
    public UnityEvent onSpreadFire;
    public UnityEvent onRapidFire;
    public UnityEvent onPump;
    public UnityEvent onPumpFinished;
    //important note for this i read this https://www.reddit.com/r/Unity3D/comments/syjz4h/how_do_i_make_my_audiosource_overlap_my_sounds/
    // and thats how i figure out how to get it to overlap itself audio wise


    public GameObject singleBullet;
    public GameObject spreadBullet;
    public GameObject rapidBullet;
    public bool SingleShotActive = false;
    public bool SpreadShotActive = false;
    public bool RapidShotActive = false;

    //check if its being held for auto fire
    public bool IsHolding = false;

    //checks if the shotgun is being pumped or not (for the forced delay between shots (coroutine
    private bool IsPumping = false;
    //how fast you can shoot the shotgun/time delayed between shots)
    public float PumpDelay = 1f;

    //auto fire config
    //this will work as a mockup countdown till the next shot basically minus the time delta time to it and it will = what the fire rate = so its "counting down" from that using time delta time every time!
    private float FireRateTimer = 0f;

    //this is where you actually adjust the fire rate
    public float FireRate = 0.1f;
    
    void Start()
    {
        
    }

    void Update()
    {
        FireRateTimer -= Time.deltaTime;

        if (IsHolding && RapidShotActive == true)
        {
            if (FireRateTimer <= 0f)
            {
                onRapidFire.Invoke();
                Instantiate(rapidBullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-2, 2)));
                FireRateTimer = FireRate;
            }
        }
        
    }

    public void FirstEquip(InputAction.CallbackContext context)
    {
        //i read up on here the defnitions more clearly on the link below when i realised there was more then just started and found out performed waits for the entire thing pressed being pressed and unpressed to compleete to then send output
        //https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/api/UnityEngine.InputSystem.InputAction.CallbackContext.html
        //here as well to grasp what is fully meant by performed
        //https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/api/UnityEngine.InputSystem.InputAction.html#UnityEngine_InputSystem_InputAction_performed
        //this shouldnt be out of scope cause its still using the same thing its just changing whats triggering it
        if (context.performed)
        {
            SingleShotActive = true;
            SpreadShotActive = false;
            RapidShotActive = false;

            //stops the pump coroutine if switching away
        }

    }
    public void SecondEquip(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SingleShotActive = false;
            SpreadShotActive = true;
            RapidShotActive = false;
        }
    }

    public void ThirdEquip(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SingleShotActive = false;
            SpreadShotActive = false;
            RapidShotActive = true;

            //stops the pump coroutine if switching away
            StopCoroutine(PumpDelaying());
            IsPumping = false;
        }
    }
    public void NoEquip(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SingleShotActive = false;
            SpreadShotActive = false;
            RapidShotActive = false;

            //stops the pump coroutine if switching away
        }
    }



    public void OnShoot(InputAction.CallbackContext context)
    {


        if (context.started == true)
        {

            IsHolding = true;

            if (SingleShotActive)
            {
                Instantiate(singleBullet, transform.position, transform.rotation);
                onSemiFire.Invoke();
            }
            if (SpreadShotActive && IsPumping == false)
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
                StartCoroutine(PumpDelaying());
                onSpreadFire.Invoke();
            }
            
        }
        //i looked through what is suggested next for context. as i knew started was already a thing so maybe stop was and found cancel
        if(context.canceled == true)
        {
            IsHolding = false;
        }

    }

    IEnumerator PumpDelaying()
    {
        IsPumping = true;
        //this one is just for audio sync
        yield return new WaitForSeconds(0.2f);
        onPump.Invoke();
        yield return new WaitForSeconds(PumpDelay);
        IsPumping = false;
        onPumpFinished.Invoke();

    }

}
