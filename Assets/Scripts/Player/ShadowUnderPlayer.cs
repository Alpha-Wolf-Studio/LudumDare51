using UnityEngine;

public class ShadowUnderPlayer : MonoBehaviour
{
    private Transform target;
    private Vector3 startPosition;

    void Start ()
    {
        target = GameplayManager.Get().playerController.transform;
        startPosition = transform.position;
    }

    void Update ()
    {
        Vector3 pos = target.position;
        pos.y = startPosition.y;
        transform.position = pos;
    }
}