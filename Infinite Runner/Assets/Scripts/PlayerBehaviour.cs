using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private float moveX;
    private float moveY;
    [SerializeField] private float moveSpeed;

    //É possível trocar o "[SerializeField] private" por "public", mas isso tornaria a variávl publica e "quebraria" as boas práticas
    void Update()
    {
        /*GetAxis: Acessa a área do input manager e confere o botão configurado e a ação definida
         * A variável ("Horizontal" ou "Vertical" nesse caso) é qual input será conferido pelo GetAxis
         * 
         */
        moveX = Input.GetAxis("Horizontal")* Time.deltaTime * moveSpeed;
        moveY = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
        //deltaTime serve para transformar o fps para segundos
        transform.Translate(moveX, moveY,0);

    }   
   
}

