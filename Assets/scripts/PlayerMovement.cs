using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;

    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        transform.Translate(new Vector2(input.x, input.y) * speed * Time.deltaTime);
        print("test");
    }
}
