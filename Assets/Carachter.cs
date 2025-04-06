using UnityEngine;

public class PlayerMove2D : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveZ = -Input.GetAxis("Horizontal");
        float moveX = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized;

        // Mișcare
        transform.Translate(move * speed * Time.deltaTime, Space.World);

        // Orientează sprite-ul spre cameră (ca să fie vizibil mereu)
        if (move != Vector3.zero)
            transform.forward = Camera.main.transform.forward;
    }
}
