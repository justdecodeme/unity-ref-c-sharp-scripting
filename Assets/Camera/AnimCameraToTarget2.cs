using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimCameraToTarget2 : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private float _rotSpeed = 30f;

    public List<Transform> camPositionList = new List<Transform>();  //asign all transforms in inspector, including the initial position
    private int clickCounter = 0;
    private int camPositionListCount = 0;
    private bool clicked = false;
    private Camera cam = null;
    PlayerControls playerControls;
    private Keyboard kb;

    void Awake() {
        playerControls = new PlayerControls();
    }

    void OnEnable() {
        playerControls.Enable();
    }

    void OnDisable() {
        playerControls.Disable();
    }

    void Start() {
        camPositionListCount = camPositionList.Count;
        cam = Camera.main;
        kb = InputSystem.GetDevice<Keyboard>();
    }

    void Update () {
    
        if (kb.spaceKey.wasPressedThisFrame) // this will rgister a click anywhere on the screen, you need to ray cast on your button
        {
            clicked = true;
            
            /* ensures that number of clicks do not exceed the number of transforms in you list else you might get an Out of Range error */
            clickCounter = Mathf.Clamp(clickCounter, 0, camPositionList.Count-1);

            clickCounter++;

            if (clickCounter == camPositionListCount) clickCounter = 0;
        }

        if(clicked) {
            MoveToNextTarget();
        }

        // NewInputSystem();
    }

    private void MoveToNextTarget() {
        Vector3 camTargetPos = camPositionList[clickCounter].position;

        if (transform.position == camTargetPos) clicked = false;

        transform.position = Vector3.MoveTowards(transform.position, camTargetPos, _speed * Time.deltaTime);

        // Quaternion lookAtTarget = Quaternion.LookRotation(camTargetPos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, camPositionList[clickCounter].rotation, _rotSpeed * Time.deltaTime);

        Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);
    }

//    void NewInputSystem() {
//         if(playerControls.Player.SpaceKey.ReadValue<float>() > 0.1f) {
//             Debug.Log("space key pressed");
//         }
//     }

    // private void GetMouseClick() {
    //     Debug.Log("GetMouseClick");
    //     if(Mouse.current.leftButton.wasPressedThisFrame) {
    //         Debug.Log("mouse clicked");
    //         Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
    //         RaycastHit hit;

    //         if(Physics.Raycast(ray, out hit)) {
    //             Debug.Log(hit.point);
    //         }
    //     }
    // }
}
