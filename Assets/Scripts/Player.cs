using UnityEngine;

public class Player : Mover
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        DontDestroyOnLoad(gameObject.transform);
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        UpdateMotor(new Vector3(x, y, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
