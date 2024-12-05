using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    [SerializeField] private TankGun turretGun;

    [SerializeField] private TankTurret turret;

    private void Update()
    {
        var worldTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        turret.LookAtTarget(worldTarget);

        turretGun.FireGun(worldTarget,Input.GetMouseButton(0));
    }

}
