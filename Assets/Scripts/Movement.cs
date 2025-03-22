using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveObject(Vector3.down);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveObject(Vector3.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveObject(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveObject(Vector3.right);
        }
    }

    private void MoveObject(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
