using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceNode : Collidable
{
    public BoxCollider2D boxCollider;
    public string resourceType;
    public int durability;

    public void Interact()
    {
        //throw new System.NotImplementedException();
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }
    //temp as interaction - maybe destroyable via attacks
    public void Gather()
    {
        if (IsColliding())
        {

        }
    }

}
