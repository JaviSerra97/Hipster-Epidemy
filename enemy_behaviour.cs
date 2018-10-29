using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_behaviour : MonoBehaviour {
    private int hp = 2;
    private Animator anim;
    public bool move;
    private bool walk;
    public float limitr, limitl;
    private int velx, aux;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update () {
        if (move)
        {
            Move();
            MoveDeath();
        }
        else
        {
            IdleDeath();
        }
	}

    public void Move()
    {
        
        if (transform.position.x >= limitr)
        {
            velx = -1;
            aux = velx;
            transform.eulerAngles = new Vector2(0, 180);
        }
        if (transform.position.x <= limitl)
        {
            velx = 1;
            aux = velx;
            transform.eulerAngles = new Vector2(0, 0);
        }
        transform.Translate(new Vector2(velx, 0) * Time.deltaTime * 0.8f, Space.World);
    }

    public void IdleDeath()
    {
        if (hp == 0)
        {
            anim.SetBool("idle_death", true);
        }
    }

    public void MoveDeath()
    {
        if (hp == 0)
        {
            anim.SetBool("death", true);
        }
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D item)
    {
        if (item.tag.Equals("Bullet"))
        {
            hp--;
            Destroy(item.gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D item)
    {
        if (item.gameObject.tag == "Player")
        {
            anim.SetBool("attack", true);
        }
    }
    void OnTriggerExit2D(Collider2D item)
    {
        if (item.gameObject.tag == "Player")
        {
            anim.SetBool("attack", false);
        }
    }
}
