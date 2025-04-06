using UnityEngine;

public class Chara : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 cameraOffset = new Vector3(0, 10, -10); // Offset pentru cameră

    private Transform cam;

    void Start()
    {
        cam = Camera.main.transform;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized;

        // Mișcare
        transform.Translate(move * speed * Time.deltaTime, Space.World);

        // Orientează sprite-ul spre cameră
        if (move != Vector3.zero)
            transform.forward = cam.forward;

        // Mișcă camera odată cu jucătorul
        cam.position = transform.position + cameraOffset;
        cam.LookAt(transform); // opțional
    }
}
