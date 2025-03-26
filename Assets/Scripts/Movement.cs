using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private float jumpPower = 30;

    private KeyCode[] buttons;

    private void Start()
    {
        var names = Input.GetJoystickNames();

        //Debug.LogFormat("Joysticks: {0}", names);

        buttons = new[] {
        KeyCode.Joystick1Button0,
        KeyCode.Joystick1Button1,
        KeyCode.Joystick1Button2,
        KeyCode.Joystick1Button3,
        KeyCode.Joystick1Button4,
        KeyCode.Joystick1Button5,
        KeyCode.Joystick1Button6,
        KeyCode.Joystick1Button7,
        KeyCode.Joystick1Button8,
        KeyCode.Joystick1Button9,
        KeyCode.Joystick1Button10,
        KeyCode.Joystick1Button11,
        KeyCode.Joystick1Button12,
        KeyCode.Joystick1Button13,
        KeyCode.Joystick1Button14,
        KeyCode.Joystick1Button15,
        KeyCode.Joystick1Button16,
        KeyCode.Joystick1Button17,
        KeyCode.Joystick1Button18,
        KeyCode.Joystick1Button19
        };
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //keyboard controls
        if (Input.GetKey(KeyCode.W))
        {
            MoveObject(Vector3.down);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveObject(Vector3.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveObject(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveObject(Vector3.right);
        }


        //gamepad controls
        if ((Input.GetAxis("Horizontal") > 0))
        {
            MoveObject(Vector3.right);
        }
        if ((Input.GetAxis("Horizontal") < 0))
        {
            MoveObject(Vector3.left);
        }
        if ((Input.GetAxis("Vertical") > 0))
        {
            MoveObject(Vector3.down);
        }
        if ((Input.GetAxis("Vertical") < 0))
        {
            MoveObject(Vector3.up);
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
            {
            JuumpObject(Vector3.forward);
        }

            //foreach (var button in buttons)
            //{
            //    if (Input.GetKeyDown(button))
            //    {
            //        Debug.LogFormat("Button {0} pressed", button);
            //    }
            //    if (Input.GetKeyUp(button))
            //    {
            //        Debug.LogFormat("Button {0} released", button);
            //    }
            //}

            //Debug.LogFormat(
            //"Primary Joystick: X: {0}; Y:{1}",
            //Input.GetAxis("Horizontal"),
            //Input.GetAxis("Vertical")
            //);
    }

    private void MoveObject(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void JuumpObject(Vector3 direction)
    {
        transform.Translate(direction * jumpPower * Time.deltaTime);
    }
}
