using UnityEngine;

public class LadoDireito : MonoBehaviour
{
     private HingeJoint2D hinge;
    private JointMotor2D motor;

    public float speed = 1000f;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        motor = hinge.motor;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            motor.motorSpeed = speed;
            hinge.motor = motor;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            motor.motorSpeed = -speed;
            hinge.motor = motor;
        }
    }
}
