using UnityEngine;
using System.Collections;

public class SimplePlayer : MonoBehaviour {    
    Animator animator;
    void Start () {
        animator = GetComponent<Animator>();
    }
    void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        bool fire = Input.GetButtonDown("Fire1");

        animator.SetFloat("Forward",v);
        animator.SetFloat("Strafe",h);
        animator.SetBool("Fire", fire);
    }
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.CompareTag("Enemy")){
            animator.SetTrigger("Die");
        }
    }
}
