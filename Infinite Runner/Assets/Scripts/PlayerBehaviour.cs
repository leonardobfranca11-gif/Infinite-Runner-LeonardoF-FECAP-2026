using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
//TODOS os "publics","privates",etc são Modificadores de acesso
{
    private float moveX;
    [SerializeField] private float moveSpeed;
    [SerializeField] private int jumpForce;
    private int jumpNumber=1;
    //É possível trocar o "[SerializeField] private" por "public", mas isso tornaria a variávl publica e "quebraria" as boas práticas
    private Rigidbody2D rigidBody;
    //Variável sem valor do tipo "Rigidbody"
    void Start()
    { 
        rigidBody= GetComponent<Rigidbody2D>();
        //Atribuo valor a Variável pegando o componente "Rigidbody" do próprio objeto
    }
    void Update()
    {
        Movimento();
        //Confere o método toda vez e ativa conforme os inputs são utiliados
        if (Input.GetButtonDown("Jump")&&jumpNumber<=1) 
        {
            PlayerJump();
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    //O "collision" é a informação do objeto com qual esse objeto colidiu
    //Método chamado quando uma colisão colide com outra qualquer
    {
        Debug.LogWarning("Colidiu com "+collision.collider.gameObject.name);
        //Mensagem de teste(a segunda parte confere a colisão(qual objeto colidiu e resgata seu nome do inspector)
        if (collision.collider.gameObject.name == "Triangle")
        {
            Destroy(this.gameObject);
        //O "this" éuma boa prática para indicar a si mesmo, mesmo que nesse caso desnecessário
        }
    }
    
    private void Movimento()
        //Criei um método para guardar a movimentação do jogador 
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //GetAxis: Acessa a área do input manager e confere o botão configurado e a ação definida
        // A variável ("Horizontal" ou "Vertical" nesse caso) é qual input será conferido pelo GetAxis
        //deltaTime serve para transformar o fps para segundos
        transform.Translate(moveX, 0, 0);


    }
    private void PlayerJump() 
        //Método para guardar o pulo
    {
        rigidBody.linearVelocityY = jumpForce;
        jumpNumber = jumpNumber-1;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "Ground")
        {
            jumpNumber = jumpNumber++;
        }
    }

}

