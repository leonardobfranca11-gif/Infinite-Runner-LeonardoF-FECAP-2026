using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private float moveX;
    private float moveY;
    public float moveSpeed;
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        transform.Translate(moveX*Time.deltaTime*moveSpeed, moveY*Time.deltaTime*moveSpeed,0);

    }   
   
}

