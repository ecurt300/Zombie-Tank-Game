using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankGun : MonoBehaviour
{
    [SerializeField] private GameObject shellGO;

    [SerializeField] private Transform muzzle;

    [SerializeField] private float shotRate;

    private float fireTime;
    public void FireGun(Vector3 mousePosition,bool fire)
    {
        if(Time.time > fireTime && fire)
        {
            TankShell shell = Instantiate(shellGO, muzzle.transform.position,muzzle.transform.rotation).GetComponent<TankShell>();
            shell.SetTarget(mousePosition,muzzle.position);
            fireTime = Time.time + shotRate;
        }
    }
  
}
