using UnityEngine;
using System.Collections;

public class SetCollisionEnemy1 : MonoBehaviour {

    float distanceWithPlayer;

    bool isAttack = true;

    public Animator anim;

    public GameObject playerObject;

    public AudioClip audioEnemydead1;

    public CircleCollider2D circleCollider;

    public static bool isDead = false;

    public AudioClip audioEnemyDead1;

	// Use this for initialization
	void Start ()
    {
        //circleCollider.enabled = false;
        anim = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
        
        if (playerObject != null)
        {
            distanceWithPlayer = transform.position.x - playerObject.transform.position.x;
        }

	}

    void XulyVaCham()
    {
        MoveMaps.stopGame = true;
        anim.SetBool("isAttack2", true);
        PlayerController.anim.SetBool("isFall", true);
        isAttack = false;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(audioEnemydead1,transform.position);
            MoveMaps.stopGame = true;
            anim.SetBool("isAttackOfEnemy", true);
            PlayerController.anim.SetBool("isFall", true);
        }
    }

    public void StopAnimation()
    {
        anim.SetBool("isAttackOfEnemy", false);
    }

    public void DestroyDead()
    {
        Destroy(gameObject);
    }

    public void BeforeDestroy()
    {
        circleCollider.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        AudioSource.PlayClipAtPoint(audioEnemyDead1, transform.position);
        if(col.gameObject.tag == "killer")
        {
            anim.SetBool("isDead", true);
            SetCollisionEnemy1.isDead = true;
        }
    }
}
