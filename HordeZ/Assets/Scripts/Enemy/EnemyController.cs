using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int enemyHealth = 5;
    [SerializeField] float enemySpeed = 1f;
    [SerializeField] string playerName = "Zombie";

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy(Vector3.back);
    }

    public void MoveEnemy(Vector3 direction) => transform.Translate(enemySpeed * Time.deltaTime * direction);
    //public void damageEnemy => enemyHealth--;
    //public void healEnemy => enemyHealth++;
    
}

