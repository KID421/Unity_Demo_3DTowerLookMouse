using UnityEngine;

public class LookMouse : MonoBehaviour
{
    private void Update()
    {
        Look();
    }

    private void Look()
    {
        Vector3 posMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 posWorld = Camera.main.ScreenToWorldPoint(posMouse);

        posWorld.y = transform.position.y;

        Vector3 direction = posWorld - transform.position;

        transform.forward = direction;
    }
}
