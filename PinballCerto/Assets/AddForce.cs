using UnityEngine;
public class ForceExample : MonoBehaviour
{
    public KeyCode inputKey = KeyCode.Space;
    public Rigidbody2D rb;
     Vector2 force ;
    void Start()
    {
    rb = GetComponent<Rigidbody2D>(); 
    force = new Vector2(0f, 50f); // Força para a cima
    
    }

    void update(){
        
           rb.AddForce(force, ForceMode2D.Impulse); // Aplica a força instantaneamente
        if (Input.GetKey(inputKey))
        {
            
        }
        else
        {
            
        }

    }
}