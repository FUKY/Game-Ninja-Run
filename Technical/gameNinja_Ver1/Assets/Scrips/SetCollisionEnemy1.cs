using UnityEngine;
using System.Collections;

public class SetCollisionEnemy1 : MonoBehaviour {

    float distanceWithPlayer;

    bool isAttack = true;

    public static Animator anim;

    public GameObject playerObject;

    public AudioClip audioEnemydead1;

    public CircleCollider2D circleCollider;

	// Use this for initialization
	void Start ()
    {
        //circleCollider.enabled = false;
        anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {

        if (playerObject != null)
        {
            distanceWithPlayer = transform.position.x - playerObject.transform.position.x;
        }

        //Collider2D[] ListCollider2D = Physics2D.OverlapPointAll(frontCheck.position);

        //Collider2D[] ListCollider2D = Physics2D.OverlapPointAll(frontCheck.position);
        //anim.SetBool("isAttack2", false);
        //foreach (Collider2D col in ListCollider2D)
        //{
        //    if (col.tag == "Player" && isAttack == true)
        //    {
        //        XulyVaCham();
        //    }
        //}

        //if (distanceWithPlayer < 0.0f)
        //{
        //    isAttack = false;
        //    anim.SetBool("isAttack2", false);
            
        //}

	}

    void XulyVaCham()
    {
        MoveMaps.stopGame = true;
        //MoveMaps.mapMoveSpeed = 0.0f;
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

}
