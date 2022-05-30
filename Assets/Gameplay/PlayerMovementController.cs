using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float dodgeStrength;

    private Rigidbody2D rb;

    private Vector2 inputVector;

    private InputAction.CallbackContext lastRotationContext;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        InputController.Instance.PlayerActions.Dodge.performed += Dodge;
        InputController.Instance.PlayerActions.Rotate.performed += Look;
    }

    private void FixedUpdate()
    {
        inputVector = InputController.Instance.PlayerActions.Movement.ReadValue<Vector2>();
        rb.velocity = inputVector * movementSpeed;
    }

    private void Dodge(InputAction.CallbackContext context)
    {
        rb.AddForce(rb.velocity.normalized * dodgeStrength, ForceMode2D.Impulse);
    }

    private void Look(InputAction.CallbackContext context)
    {
        if (InputController.Instance.PlayerActions.Rotate.activeControl?.device.description.deviceClass == "Mouse")
        {
            Vector2 mouseInput = InputController.Instance.PlayerActions.Rotate.ReadValue<Vector2>();

            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouseInput.x, mouseInput.y, 0));
            Vector2 lookDirection = mouseWorld - transform.position;
            float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
        }
        else
        {
            Vector2 mouseInput = InputController.Instance.PlayerActions.Rotate.ReadValue<Vector2>();

            float angle = Mathf.Atan2(mouseInput.y, mouseInput.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
        }
    }
}
