using UnityEngine;

[RequireComponent(typeof(BoatMover))]
public class StateSwitcherPlayer : MonoBehaviour
{
    [SerializeField] private Hook _hook;
    [SerializeField] private HarpoonControl _harpoonControl;
    [SerializeField] private Laser _laser;
    [SerializeField] private float rotationSpeed = 5f; 

    private BoatMover _boatMover;

    private bool isRotating = false; 
    private Quaternion desiredRotation;
    private Vector3 desiredPosition;

    private void Start()
    {
        _boatMover = GetComponent<BoatMover>();
    }

    private void Update()
    {
        if (isRotating)
        {
            // Плавное вращение персонажа вокруг оси Z
            transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);

            // Проверка, достиг ли персонаж желаемого поворота
            if (Quaternion.Angle(transform.rotation, desiredRotation) < 0.1f)
            {
                isRotating = false;
                _hook.enabled = true;
                _laser.OnRenderer();
                _harpoonControl.enabled = true;
            }
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.TryGetComponent(out AreaForBoat areaForBoat))
        {
            RotateToAxisZ(areaForBoat);
            _boatMover.enabled = false;
            areaForBoat.StartSpawnFish();
        }
    }
    
    private void RotateToAxisZ(AreaForBoat area)
    {
        isRotating = true;

        Vector3 targetDirection = Vector3.forward;
        desiredRotation = Quaternion.LookRotation(targetDirection, Vector3.up);
    }
}
