using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float velocity = 1000;
    public Animator animator;

    private SpriteRenderer _renderer;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        /*GetComponent<Collision>().winText.enabled = false;
        GetComponent<Collision>().button.gameObject.SetActive(false);*/

        _renderer = GetComponent<SpriteRenderer>();
        if (_renderer == null)
        {
            Debug.LogError("Player Sprite is missing a renderer");
        }
    }


    void Update()
    {

        float movimentoX = Input.GetAxisRaw("Horizontal") * velocity;
        float movimentoY = Input.GetAxisRaw("Vertical") * velocity;

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            _renderer.flipX = false;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            _renderer.flipX = true;
        }
        animator.SetFloat("Speed", Mathf.Abs(movimentoX));
        rigidBody.velocity = new Vector2(movimentoX, movimentoY);

        
    }

}
