using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLuncher;
    public TurretBlueprint laserBeamer;

    BuildManager buildManager;

    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Purchase");
        buildManager.SelectTurretToBuild(standardTurret);
    }


    public void SelectMissileLuncher()
    {
        Debug.Log("Missile Luncher Purchase");
        buildManager.SelectTurretToBuild(missileLuncher);
    }


    public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer Slected");
        buildManager.SelectTurretToBuild(laserBeamer);
    }


    // Start is called before the first frame update
    void Start()
    {
        buildManager = BuildManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
