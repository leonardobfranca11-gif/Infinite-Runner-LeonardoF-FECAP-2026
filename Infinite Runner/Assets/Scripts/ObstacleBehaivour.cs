using UnityEngine;

public class ObstacleBehaivour : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private float moveX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //O -1 move para esquerda (por causa da lógica do plano cartesiano) na velocidade do "moveSpeed" unidades por segundo (deltaTime)
        moveX = -1 * Time.deltaTime * moveSpeed;
        transform.Translate(moveX, 0, 0);
    }
}
