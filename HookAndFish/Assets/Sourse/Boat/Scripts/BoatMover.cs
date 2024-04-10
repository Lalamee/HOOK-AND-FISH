using UnityEngine;

public class BoatMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float _rotationSpeed = 4f;

    private AreaForBoat[] _allTargetAreas; 

    private void Start()
    {
        FindAllTargetAreas();
    }

    private void Update()
    {
        Vector3 nearestTarget = FindNearestTarget();
        MoveToTarget(nearestTarget);
    }

    private void FindAllTargetAreas()
    {
        _allTargetAreas = FindObjectsOfType<AreaForBoat>();
    }

    private Vector3 FindNearestTarget()
    {
        if (_allTargetAreas == null || _allTargetAreas.Length == 0)
        {
            Debug.LogWarning("Ќе найдены точки дл€ перемещени€ лодки.");
            return transform.position;
        }

        Vector3 nearestTarget = _allTargetAreas[0].transform.position;
        float nearestDistance = Mathf.Infinity;

        foreach (AreaForBoat area in _allTargetAreas)
        {
            Vector3 targetPoint = area.transform.position;
            float distance = Vector3.Distance(transform.position, targetPoint);
            if (distance < nearestDistance)
            {
                nearestTarget = targetPoint;
                nearestDistance = distance;
            }
        }

        return nearestTarget;
    }

    private void MoveToTarget(Vector3 target)
    {
        float scaledMoveSpeed = _moveSpeed * Time.deltaTime;

        Vector3 moveDirection = (target - transform.position).normalized;
        transform.position += moveDirection * scaledMoveSpeed;

        RotateToTarget(moveDirection);
    }

    private void RotateToTarget(Vector3 moveDirection)
    {
        float scaledRotationSpeed = _rotationSpeed * Time.deltaTime;

        Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, scaledRotationSpeed);
    }
}