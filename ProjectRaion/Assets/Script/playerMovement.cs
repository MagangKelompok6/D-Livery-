
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private float jump;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float checkRadius;
    [SerializeField] private int jumpValue;
    [SerializeField] private Rigidbody2D rb;
    public bool isGrounded;
    public int midAirJump;
    // Start is called before the first frame update
    void Start()
    {
        midAirJump = jumpValue;
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, layerMask);
        if (isGrounded == true)
        {
            midAirJump = jumpValue;
            this.GetComponent<Animator>().SetBool("isJump",false);
        }
        if (midAirJump > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jump;
            midAirJump--;
            this.GetComponent<Animator>().SetBool("isJump",true);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && midAirJump == 0 && isGrounded == true)
        {
            this.GetComponent<Animator>().SetBool("isJump",true);
            rb.velocity = Vector2.up * jump;
        }
    }
}
