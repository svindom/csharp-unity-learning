using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public abstract class EnemyAbstractLearning : MonoBehaviour
{
    public int speed;
    public int health;
    public int gem;

    public abstract void Atack();

    public virtual void Die()
    {
        Destroy(this.gameObject);
    }
}

public class MossGiant : EnemyAbstractLearning
{
    public override void Atack()
    {
        throw new System.NotImplementedException();
    }
    public override void Die()
    {
        // custom particles
        base.Die();
    }
}


