using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempInvulnerable : MonoBehaviour
{
    Renderer renderer;
    Color clr;
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        clr = renderer.material.color;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Truck") && gameObject.GetComponent<health>().healths == 1||
            collision.gameObject.name.Equals("Car") && gameObject.GetComponent<health>().healths == 1)
        {
            Debug.Log(collision.gameObject.name);
            StartCoroutine("invulnerable");
        }
    }
    IEnumerator invulnerable()
    {
        Physics2D.IgnoreLayerCollision(9, 10, false);
        Physics2D.IgnoreLayerCollision(9, 8, true);
        clr.a = 0.5f;
        renderer.material.color = clr;
        yield return new WaitForSeconds(3f);
        clr.a = 1;
        renderer.material.color = clr;
        Physics2D.IgnoreLayerCollision(9, 8, false);
        Physics2D.IgnoreLayerCollision(9, 10, true);
    }
}
