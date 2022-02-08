using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int playerHealth = 3;
    [SerializeField] float playerSpeed = 1f;
    [SerializeField] string playerName = "Juan Carlos";

    void Start()
    {
        Debug.Log("Starting"); // Imprimir en consola
        Debug.Assert(playerHealth > 0, "La vida debe ser mayor que 0"); // Afirmación
        transform.position = new Vector3(0, 1, -10);

        //--- Modificar escala ---
        //transform.localScale = new Vector3(3.1f, 3.1f, 3.1f);  
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(Vector3.forward);    
        //MovePlayer(Vector3.back);    // Eje -Z (0,0,-1)
        //MovePlayer(Vector3.forward); // Eje +Z (0,0,1)
        //MovePlayer(Vector3.left);    // Eje -X (-1,0,0)
        //MovePlayer(Vector3.right);   // Eje +X (1,0,0)
        //MovePlayer(Vector3.up);      // Eje +Y (0,1,0)
        //MovePlayer(Vector3.down);    // Eje -Y (0,-1,0)
    }

    public void MovePlayer(Vector3 direction) => transform.Translate(playerSpeed * Time.deltaTime * direction);

    public void damagePlayer() => playerHealth--;

    public void healPlayer() => playerHealth++;

}
