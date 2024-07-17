using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    [SerializeField] Ninja ninja;

    private BaseState currentState;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        ChangeState(new NinjaIdle(this));
    }

    void Update()
    {
        currentState.Update();
    }

    public void ChangeState(BaseState newState)
    {
        if (currentState != null)
            currentState.Exit();

        currentState = newState;
        currentState.Enter();
    }

    public void Move(float direction)
    {
        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
        if (direction != 0)
            transform.localScale = new Vector3(Mathf.Sign(direction), 1, 1);
    }

    public void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    public void TakeDamage(float damage)
    {
        ChangeState(new NinjaHurt(this));

        ninja.HP -= damage;
        if (Mathf.Approximately(ninja.HP, 0f)) Die();
    }

    public void Die()
    {
        ChangeState(new NinjaDie(this));
    }
}
