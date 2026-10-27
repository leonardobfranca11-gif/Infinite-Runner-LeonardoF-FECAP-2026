using UnityEngine;

public class NoButtonMove : MonoBehaviour
{
    private float moveX;
    [SerializeField] private float moveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = -1 * Time.deltaTime*moveSpeed;
        transform.Translate(moveX, 0, 0);
    }
}
