using UnityEngine;
using System.Collections;

public class CollisionWithPlayer : MonoBehaviour {

    // circle collider 2d cua enemy
    CircleCollider2D circle;

    // animator 
    public Animator anim_E;

    //khoang cach enemy vs player
    float distancePlayer;

    public static bool run = true;
    //
    public float moveSpeed;

    public GameObject PlayerObject;

    public AudioClip audioEnemyDead;
	// Use this for initialization
   
	void Start () {
        // get circle collider cua enemy
        circle = gameObject.GetComponent<CircleCollider2D>();
       
        //get animator cua enemy
        anim_E = GetComponent<Animator>();

        
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerObject != null)
        {
            distancePlayer =Mathf.Abs(transform.position.x - PlayerObject.transform.position.x);
           // Debug.Log(distancePlayer);
        }

        //neu khoang cach giua enemy vs Player < 6 set animation cho enemy
        if (distancePlayer < 6.0f && run == true)
        {
            anim_E.SetBool("isRun_E", true);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,0.0f);
        }
	}


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            MoveMaps.stopGame = true;
            run = false;
            PlayerController.anim.SetBool("isFall", true);
            anim_E.SetBool("isFall_E", true);
            AudioSource.PlayClipAtPoint(audioEnemyDead,transform.position);
        }
    }
}
