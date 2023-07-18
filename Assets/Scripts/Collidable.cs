using UnityEngine;

public class Collidable : MonoBehaviour
{
    // to control wich contact results get returned;
    public ContactFilter2D filter;
    // colider on obj
    private BoxCollider2D boxColider;
    //Array to keep track of whats colliding in each frame
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        boxColider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update()
    {
        // gets filtering of collisions above/beneath obj and puts it in hits array
        boxColider.OverlapCollider(filter, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
                continue;

            IsColliding();
            OnCollide(hits[i]);

            //clearing array
            hits[i] = null;
        }
    }

    protected virtual void OnCollide(Collider2D coll)
    {
        Debug.Log(coll.name);
    }
    protected virtual bool IsColliding()
    {
        return true;
    }
}
