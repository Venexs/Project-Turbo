using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamage = 40;

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
