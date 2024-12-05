using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShell : MonoBehaviour
{
    /*Set Target then move to towards target position then explode killing 
     * Zombies
     */

    private const float shellSpeed = 100;
    private const float dieTime = 0.5f;
    private bool isShot { get; set;}
    private Vector3 target { get; set; }
    private Vector3 muzzle;
    public void SetTarget(Vector3 target,Vector3 muzzle)
    {
        this.target = target;
        this.muzzle = muzzle;
        isShot = this.target == null;
    }

    void MoveTowardsTarget()
    {
        if (!isShot)
        {


            var direction = (target - muzzle);
            var angle = Mathf.Atan2(direction.normalized.y, direction.normalized.x) * Mathf.Rad2Deg;
            transform.position = Vector3.MoveTowards(transform.position, muzzle + direction, shellSpeed * Time.deltaTime);
            transform.eulerAngles = Vector3.forward * angle;
        }
    }

    private void Update()
    {
        MoveTowardsTarget();
        Destroy(this.gameObject,dieTime);
    }

}
