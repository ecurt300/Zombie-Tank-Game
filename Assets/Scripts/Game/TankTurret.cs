using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TankTurret : MonoBehaviour
{
    /*
     * Looks a the mouseposition in world space really aims towards it
     * 
     */

    private const float aimSpeed = 10;
    [SerializeField] private Transform turretMuzzle;
    public void LookAtTarget(Vector3 mousePosition)
    {
        //TODO use unity's new input system



        var direction =  mousePosition - transform.localPosition;

        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

       
        var smoothDampedAngle = Mathf.Lerp(0, angle ,( 1- Mathf.Sin(angle * aimSpeed * Mathf.PI) *Time.deltaTime));

        transform.eulerAngles = Vector3.forward * smoothDampedAngle;
        
    }
}
