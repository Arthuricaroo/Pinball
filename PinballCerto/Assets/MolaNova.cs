using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(SpringJoint2D))]
public class PlungerSpring : MonoBehaviour
{
    public Rigidbody2D plungerRb;
    public float pullForce = 10f; // Força com que o jogador puxa
    public float maxPullDistance = 2f; // Limite máximo de puxada
    private Vector2 initialPosition;
    private bool isPulling = false;

    void Start()
    {
        plungerRb = GetComponent<Rigidbody2D>();

        initialPosition = plungerRb.position;
        plungerRb.bodyType = RigidbodyType2D.Dynamic;
        plungerRb.gravityScale = 0f; // sem gravidade
        plungerRb.freezeRotation = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            isPulling = true;

            if (Vector2.Distance(plungerRb.position, initialPosition) < maxPullDistance)
            {
                plungerRb.MovePosition(plungerRb.position - Vector2.up * pullForce * Time.deltaTime);
            }
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) && isPulling)
        {
            isPulling = false;
            // Quando solta, o spring joint puxa automaticamente o plunger de volta
            // Não precisa fazer mais nada — a mola (spring) faz o trabalho
            plungerRb.AddForce(Vector2.up * 50f, ForceMode2D.Impulse);
        }
    }
}
