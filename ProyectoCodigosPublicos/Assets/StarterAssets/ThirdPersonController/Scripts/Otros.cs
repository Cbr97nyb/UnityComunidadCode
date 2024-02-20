using UnityEngine;

public class Otros : MonoBehaviour
{
    public Vector3 targetPosition;
    public void Metodo1Mostrado(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f))
        {
            //Debug.Log(raycastHit.collider.gameObject);
            if (raycastHit.collider.gameObject.TryGetComponent<Rigidbody>(out Rigidbody rigidbody))
            {
                rigidbody.AddExplosionForce(1000f, targetPosition,5f);
            }
        }
    }
}
