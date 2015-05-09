using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public static Animator anim;

    public float jumbForce = 500.0f;

    public LayerMask layerMaskGoundCheck;

    public Transform tranformGroundCheck;

    bool grounded;

    public static Transform tranformPlayer;

    float playerPosStartX = 0.0f;

    public Text scoreText;

   // public Transform frontCheck;

    public AudioClip audioAttack;

    public AudioClip audioJumb;

    public AudioClip audioScore;

    bool Jumbed = false;

    int score =0 ;
	// Use this for initialization
	void Start () {
	    anim = GetComponent<Animator>();
        playerPosStartX = gameObject.transform.position.x;

        scoreText.text = "Score:0";
	}

    void XuLyAttack()
    {
        anim.SetBool("isAttack", true);
    }

 
	void Update () {

        grounded = Physics2D.OverlapCircle(tranformGroundCheck.position, 0.1f, layerMaskGoundCheck);

        anim.SetBool("isRun", grounded);

        //if (Input.GetKeyDown(KeyCode.Space) && grounded)
        //{
        //    AudioSource.PlayClipAtPoint(audioJumb,transform.position);
        //    GetComponent<Rigidbody2D>().velocity = new Vector2(0,jumbForce);
        //}

        //if (Input.GetKeyDown(KeyCode.A) && grounded)
        //{
        //    anim.SetBool("isAttack", true);           
        //    AudioSource.PlayClipAtPoint(audioAttack, transform.position);
        //}
        
	}

    public void Jumb()
    {
        if (grounded)
        {
            AudioSource.PlayClipAtPoint(audioJumb, transform.position);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumbForce);
        }
    }

    public void Attack()
    {
        if (grounded)
        {
            anim.SetBool("isAttack", true);
            AudioSource.PlayClipAtPoint(audioAttack, transform.position);
        }
    }

    public void FixedUpdate()
    {
        CheckPosition();
        scoreText.text = "Score:" + score.ToString(); 
    }
    void CheckPosition()
    {
        if (gameObject.transform.position.x < playerPosStartX)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(5.0f,0.0f));
        }
    }

    //kết thúc animation
    public void LastAnimation()
    {
        anim.SetBool("isAttack", false);
    }

    // bắt đầu animation

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Score")
        {
            AudioSource.PlayClipAtPoint(audioScore,transform.position);
            score += 1;
            Destroy(col.gameObject);
        }
    }

    public void Demo()
    {
        Debug.Log("demo");
    }
}
