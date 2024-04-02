using UnityEngine;

public class AimingScript : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        // Hae hiiren sijainti ruudulla
        Vector3 mousePosition = Input.mousePosition;

        // Muunna hiiren sijainti maailman koordinaatistoon
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.transform.position.y - transform.position.y));

        // K‰‰nn‰ hahmoa kohti hiiren sijaintia
        Quaternion targetRotation = Quaternion.LookRotation(mousePosition - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
