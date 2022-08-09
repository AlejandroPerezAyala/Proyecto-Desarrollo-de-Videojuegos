using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    //creo variable enmu para diferenciar el movimiento de los enemigos en el juego
    enum EnemysTypes {Ghost, Skeleton, Vampire}
    //variable para determinar mediante inspector que tipo de enemigo es
    [SerializeField] EnemysTypes EnemyType;
    //variable para determinar mediante el inspector el transform del player
    [SerializeField] Transform Player;
    public float Velocidad;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         switch (EnemyType)
        {
            case EnemysTypes.Ghost:
                LookPlayer();
                break;
            case EnemysTypes.Skeleton:
                ChasePlayer();
                break;            
        }
    }

    //Metodo para que el enemiga siga al player
    void ChasePlayer()
    {
        Vector3 Chase = (Player.position - transform.position);
        if(Chase.magnitude > 2f)
        {
            LookPlayer();
            transform.position += Chase.normalized * Time.deltaTime * Velocidad;
        }
        
    }

    //Metodo para mirar al jugador con Quaternions
    void LookPlayer()
    {
        Quaternion Look = Quaternion.LookRotation(Player.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, Look, 3f * Time.deltaTime);
    }
}
