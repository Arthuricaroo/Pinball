    using UnityEngine;

public class Flipper : MonoBehaviour
{
    public KeyCode inputKey = KeyCode.RightArrow; // Tecla de ativação
    public float restPosition = 0f;              // Ângulo de descanso
    public float pressedPosition = 45f;          // Ângulo ao pressionar a tecla
    public float flipperStrength = 10000f;       // Força da mola
    public float flipperDamper = 150f;           // Amortecimento da mola

    private HingeJoint2D hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        JointAngleLimits2D limits = hinge.limits;
        limits.min = restPosition;
        limits.max = pressedPosition;
        hinge.limits = limits;
        hinge.useLimits = true;

        JointMotor2D motor = hinge.motor;
        motor.maxMotorTorque = flipperStrength;
        hinge.motor = motor;
        hinge.useMotor = true;
    }

    void Update()
    {
        JointMotor2D motor = hinge.motor;

        if (Input.GetKey(inputKey))
        {
            motor.motorSpeed = -flipperStrength;
        }
        else
        {
            motor.motorSpeed = flipperStrength;
        }

        hinge.motor = motor;
    }
}

