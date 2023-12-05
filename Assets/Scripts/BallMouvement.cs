using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMouvement : MonoBehaviour
{
    public float startSpeed;
    public float extraSpeed;
    public float maxExtraSpeed;
    private int hitCounter = 0;
    private Rigidbody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }
    public IEnumerator Launch () { 
        hitCounter=0;
        yield return new WaitForSeconds(1);
        MoveBall(new Vector2(-1, 0));
    }
    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float ballSpeed = startSpeed + hitCounter * extraSpeed;
        rb.velocity = direction * ballSpeed;
    }
    public void IncreaseHitCounter ()
    {
        if (hitCounter * extraSpeed < maxExtraSpeed) 
        {
            hitCounter++;
        }
    }

    // Update is called once per frame
  
}
