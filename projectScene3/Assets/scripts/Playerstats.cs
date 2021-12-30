using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerstats : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 6;
    public int lives = 3;

    public float flickerduration = 0.1f;
    private float flickertime = 0f;
    private SpriteRenderer spriterenderer;

    public bool isImmune = false;
    public float immunityDuration = 1.5f;
    private float immunityTime = 0f;
    public AudioClip GameOverSound;
    void Start()
    {
        spriterenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (this.isImmune == true)
        {
            SpriteFlicker();
            immunityTime = immunityTime + Time.deltaTime;
            if (immunityTime >= immunityDuration)
            {
                this.isImmune = false;
                this.spriterenderer.enabled = true;
            }
        }
        */
        }

    /*
    public void takedamage(int damage)
    {
        if (this.isImmune == false)
        {
            this.health = this.health - damage;
            if (this.health < 0f)
            {
                this.health = 0;
            }
            if (this.lives > 0f && this.health == 0f)
            {
                FindObjectOfType<Levelmanager>().respawnplayer();
                this.health = 6;
                this.lives--;
            }
            else if (this.lives == 0 && this.health == 0)
            {
                Debug.Log("Game over");
                Destroy(this.gameObject);
            }
            Debug.Log("Player health:" + this.health.ToString());
            Debug.Log("Player lives:" + this.health.ToString());
        }
        Playhitreaction();
    }
    void Playhitreaction()
    {
        this.isImmune = true;
        this.immunityTime = 0f;
    }

    

    void SpriteFlicker()
    {
        if (this.flickertime < this.flickerduration)
        {
            this.flickertime = this.flickertime + Time.deltaTime;
        }
        else if (this.flickertime >= this.flickerduration)
        {
            spriterenderer.enabled = !(spriterenderer.enabled);
            this.flickertime = 0;
        }
    }
    */
}

