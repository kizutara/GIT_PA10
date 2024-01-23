using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float playerSpeed;
    private float force = 150f;
    public Rigidbody rigidbody;
    public GameObject obstacle;
    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            fly();
        }
        if (rigidbody.position.y < -7)
        {
            SceneManager.LoadScene("lose");
        }
    }
    private void fly()
    {
        rigidbody.velocity = Vector3.zero;
        rigidbody.AddForce(Vector3.up * force);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            SceneManager.LoadScene("lose");
        }
    }
}
