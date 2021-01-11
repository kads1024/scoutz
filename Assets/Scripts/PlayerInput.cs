using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
    public float MovementSpeed;


    public float rotationSmoothness;
    public float movementSmoothness;

    private float currentSpeed;
    private float rotationVelocity;
    private float speedVelocity;

    Transform cameraTransform;
    public FixedJoystick joystick;

    Animator animator;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputAxis = new Vector2(joystick.input.x, joystick.input.y);
        Vector2 inputDir = inputAxis.normalized;
        animator.SetInteger("Run", inputDir != Vector2.zero ? 1: 0);
        if (inputDir != Vector2.zero)
        {
            float rotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg + cameraTransform.eulerAngles.y;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, rotation, ref rotationVelocity, rotationSmoothness);
        }
        float targetSpeed = MovementSpeed * inputDir.magnitude;
        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedVelocity, movementSmoothness);
        transform.Translate(transform.forward * Time.deltaTime * currentSpeed, Space.World);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Lost")
        {
            PlayerPrefs.SetInt("FindingMinigame", 1);


            if (!PlayerPrefs.HasKey(PlayerPrefs.GetString("CurrentMinigame")))
            {
                PlayerPrefs.SetString(PlayerPrefs.GetString("CurrentMinigame"), "COMPLETE");
            }

            SceneManager.LoadScene("GameOver");
        }
    }
}
