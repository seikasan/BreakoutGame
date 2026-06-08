using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        float x = 0f;

        if (Keyboard.current.aKey.isPressed)
        {
            x = -1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            x = 1f;
        }

        transform.position += new Vector3(x, 0, 0) * _moveSpeed * Time.deltaTime;
    }
}
