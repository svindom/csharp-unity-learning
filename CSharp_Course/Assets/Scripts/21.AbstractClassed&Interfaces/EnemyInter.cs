using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInter : MonoBehaviour, IDamagable, IShootable
{
    public int Health {  get; set; }
    public int damageAmount = 0;


    public void Damage(int damageAmount)
    {
        this.damageAmount = damageAmount;
        Health -= damageAmount;
    }

    public void Shoot()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
