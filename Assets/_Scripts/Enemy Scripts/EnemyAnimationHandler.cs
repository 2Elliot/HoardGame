using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationHandler : MonoBehaviour
{

    Animator animator;
    SpriteRenderer spriteRenderer;
    Transform player;
    Transform parent;

    void Start()
    {
		parent = transform.parent;
        animator = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player").transform;
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (transform.position.x >= player.position.x + 0.5f && animator.GetBool("MovingRight")) {
            animator.SetBool("MovingRight", false);
        } else if (transform.position.x <= player.position.x - 0.5f && !animator.GetBool("MovingRight")) {
            animator.SetBool("MovingRight", true);
        }

        if (parent != null) {
            transform.position = parent.transform.position;
        } else {
			Destroy(this.gameObject);
		}
    }

    // TODO: Make sprite renderer flash white when in contact with player
    // private void OnCollisionEnter2D(Collision2D other) {
    //     if (other.gameObject.compareTag("Player")) {
    //         spriteRenderer.sprite = new Color (White);
    //     }
    // }

    public void LooseParent() {
		transform.parent = null;
	}
}
