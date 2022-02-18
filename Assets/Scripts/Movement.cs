using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Player;
    private int speed = 10;

    private float upDownInput;
    private float movementInputx;
    private float movementInputy;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Input.GetKeyDown(KeyCode.JoystickButton0);
        upDownInput = Input.GetAxis("Xbox Right Joystick Vertical") + OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.RTouch).x;
        movementInputx = Input.GetAxis("Horizontal") + OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.LTouch).x;
        movementInputy = Input.GetAxis("Vertical") + OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.LTouch).y;
        if(movementInputx != 0 &&  movementInputy != 0 && upDownInput != 0)
        {
            print("X Movement: "+Mathf.Clamp(-1 * movementInputx, -0.07f, 0.07f));
            print("Y Movement: "+Mathf.Clamp(-1 * movementInputy, -0.07f, 0.07f));
            print("Z Movement: " + Mathf.Clamp(-1 * upDownInput, -0.07f, 0.07f));
            var playerMovement = new Vector3(-(Mathf.Clamp(movementInputx, -0.07f, 0.07f)) ,-(Mathf.Clamp(upDownInput, -0.07f, 0.07f)), -(Mathf.Clamp(movementInputy, -0.07f, 0.07f)));
            Player.transform.Translate(playerMovement,Space.Self);
        }*/

        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Player.transform.position += Movement * speed * Time.deltaTime;
    }
}
