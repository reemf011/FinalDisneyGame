using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    /*
    Transform Player;
    float agroRange;
    float moveSpeed;
    float distanceToPlayer;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
        //distance to player
        distanceToPlayer = Vector2.Distance(transform.position, Player.position);
        if (distanceToPlayer < agroRange)
        {  //chase the player
            chasePlayer();
        }
        else
        { //stop chasing the player
            StopChasingPlayer();
        }
    }

    void chasePlayer()
    {
        if (transform.position.x < Player.position.x)
        {
            //
            rb2d.velocity = new Vector2(moveSpeed, 0);
        }

        else if (transform.position.x > Player.position.x)
        {
            rb2d.velocity = new Vector2(-moveSpeed, 0);


        }


    }


    void StopChasingPlayer()
     {

     }

}
    */

    /*

    // Start is called before the first frame update
    public bool isfacingRight = false;
    public float maxSpeed = 3f;
    public int damage = 3;
    public void flip()
    {
        isfacingRight = !isfacingRight;
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<Playerstats>().takedamage(damage);
        }
    }
    */
    public GameObject Player;
    private Transform playerPos;
    private Vector2 currentPos;
    public float distance;
    public float speedEnemy;
    private Animator enemyAnim;
    void Start()
    {
        playerPos = Player.GetComponent<Transform>();
        currentPos = GetComponent<Transform>().position;
        enemyAnim = GetComponent<Animator>();

    }

    void Update()
    {
        if (Vector2.Distance(transform.position, playerPos.position) < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speedEnemy * Time.deltaTime);
            enemyAnim.SetBool("fly", true);
        }
        else
        {
            if (Vector2.Distance(transform.position, playerPos.position) <= 0)
            {
                enemyAnim.SetBool("fly", false);
            }

            else
            {
                transform.position = Vector2.MoveTowards(transform.position, currentPos, speedEnemy * Time.deltaTime);
                enemyAnim.SetBool("fly", true);

            }
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<Levelmanager>().respawnplayer();
            healthBar.health -= 10f;

        }
    }

    

}
