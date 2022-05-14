using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullet : MonoBehaviour
{

    public float BulettSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        if (Player.instance.RLChecker)
        {
            transform.Translate(Vector3.right * Time.deltaTime * BulettSpeed);
        }
        else
        {
            transform.Translate(Vector3.right * -1 *Time.deltaTime * BulettSpeed);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            //Destroy(this, collision.gameObject);
            //Destroy(this, gameObject);
        }
    }
}