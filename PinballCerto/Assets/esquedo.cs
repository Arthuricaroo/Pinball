using UnityEngine;

public class LadoEsquerdo : MonoBehaviour
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            motor.motorSpeed = -speed;
            hinge.motor = motor;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            motor.motorSpeed = speed;
            hinge.motor = motor;
        }
    }
}
