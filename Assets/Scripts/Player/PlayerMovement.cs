using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;
    private float _threshold = 0.1f;

    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;
    private Vector2 _smoothedMovementInput;
    private Vector2 _movementInputSmoothVelocity;
    private Vector2 _lastMovementDirection;

    private Animator _animator;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        _smoothedMovementInput = Vector2.SmoothDamp(
            _smoothedMovementInput,
            _movementInput,
            ref _movementInputSmoothVelocity,
            0.1f);

        _rigidbody.velocity = _smoothedMovementInput * _speed;

        // Calcula a magnitude do movimento
        float movementMagnitude = _smoothedMovementInput.magnitude;

        if (movementMagnitude > _threshold)
        {
            // Armazena a última direção de movimento válida
            _lastMovementDirection = _smoothedMovementInput;
            _animator.SetFloat("Horizontal", _smoothedMovementInput.x);
            _animator.SetFloat("Vertical", _smoothedMovementInput.y);
        }
        else
        {
            // Usa a última direção de movimento válida
            _animator.SetFloat("Horizontal", 0);
            _animator.SetFloat("Vertical", 0);
        }

        _animator.SetFloat("LastHorizontal", _lastMovementDirection.x);
        _animator.SetFloat("LastVertical", _lastMovementDirection.y);
    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>();
    }
}
