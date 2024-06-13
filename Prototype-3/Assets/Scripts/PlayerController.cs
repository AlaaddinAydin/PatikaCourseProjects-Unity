using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;

    public float jumpForce = 10;

    public float gravityModifier;

    public bool isOnGround = true;

    public bool gameOver;


    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();

        //playerRb.AddForce(Vector3.up * 1000);

        /*karakteri yukarı zıplatıyor gibi havaya kaldıracam için.*/

        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
            // ForceMode.Impulse = Uygulanan kuvveti anında cisme uygular. (Zıplama efekti için burada kullandık)
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //isOnGround = true; Her hangi bir çarpışma olduğunda bize yerdemi? değişkenini değiştirecekti.

        if(other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }else if(other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game is Over");
            gameOver = true;

            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }
}
