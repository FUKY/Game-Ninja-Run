using UnityEngine;
using System.Collections;

public class Killer : MonoBehaviour {

    Collider2D killerCollider;

    public AudioClip audioEnemyDead1;

    public Animator animOfEnemy;
	// Use this for initialization
	void Start () {
        //Destroy(gameObject,0.5f);
        killerCollider = gameObject.GetComponent<BoxCollider2D>();
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            AudioSource.PlayClipAtPoint(audioEnemyDead1,transform.position);
            //Destroy(col.gameObject);
            SetCollisionEnemy1.anim.SetBool("isDead",true);
        }
    }
}
