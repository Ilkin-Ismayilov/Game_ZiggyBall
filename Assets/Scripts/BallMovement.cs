using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BallMovement : MonoBehaviour
{
    Vector3 direction;
    public float speed;
    public GroundSpawner GroundSpawnerScript;
    public static bool fallof;
    public float speedToBeAdded;
    public UIManager uiManager;
    
    
    void Start()
    {
        Time.timeScale = 1f;
        direction = Vector3.forward;
        fallof = false;
    }

    void Update()
    {
        if (transform.position.y <= 0.5f)
        {
            fallof = true;
            
            uiManager.ShowGameOverMenuDelayed();
        }
        if (fallof == true)
        {
            return;
        }
       if (Input.GetMouseButtonDown(0))
        {
            if (direction.x == 0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
            speed += speedToBeAdded * Time.deltaTime;
        } 
    }
    private void FixedUpdate()
    {
        Vector3 movement = direction * speed * Time.deltaTime;
        transform.position += movement;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "CurrentGround")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            GroundSpawnerScript.createGround();
            StartCoroutine(DeleteGround(collision.gameObject));
        }
    }

    IEnumerator DeleteGround(GameObject GroundToBeDeleted)
    {
        yield return new WaitForSeconds(3f);
        Destroy(GroundToBeDeleted);
    }
}
