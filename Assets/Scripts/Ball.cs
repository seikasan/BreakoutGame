using UnityEngine;
 
public class Ball : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Vector2 _direction = new Vector2(0, 1);
 
    private void Start()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddForce(_direction.normalized * _moveSpeed * Time.deltaTime, ForceMode.Impulse);
    }
}
