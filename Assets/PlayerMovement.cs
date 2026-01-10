using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float moveStep = 1.0f;
    public void MoveLeft() { transform.Translate(Vector2.left * moveStep); }
    public void MoveRight() { transform.Translate(Vector2.right * moveStep); }
}