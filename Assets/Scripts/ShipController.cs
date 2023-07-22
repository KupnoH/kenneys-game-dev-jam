using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 40;
    public float horizontalSwayAmount = 1f;
    public float verticalwayAmount = 2f;
    public GameObject cannonPrefab;
    public Transform cannonSpawnPoint;
    public GameObject playerPrefab;
    public Transform playerSpawnPoint;

    private bool isPlayerOnShip = true;
    public PlayerManager playerManager;
    private CannonController cannonController;
    public float maxDistance = 10f;
    public LayerMask islandLayer;
    void Start()
    {
        cannonController = GetComponent<CannonController>();
    }


    void Update()
    {
        // Ship movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * (speed * Time.deltaTime));

        // Ship rotation
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        //Ship swaying
        //SwayShip();

        // Cannon attack
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cannonController.Fire(cannonPrefab, cannonSpawnPoint);
        }

        // Player disembark
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    if (isPlayerOnShip)
        //    {
        //        RaycastHit hit;
        //        if (Physics.SphereCast(transform.position, maxDistance, Vector3.forward, out hit, 1, islandLayer))
        //        {

        //        }
        //    }
        //}
    }
    //private void SwayShip()
    //{
    //    m_Ship.transform.rotation = Quaternion.Euler(Mathf.Cos(Time.time) * verticalwayAmount, 0, Mathf.Sin(Time.time) * horizontalSwayAmount);
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Land"))
        {
            if (Input.GetKeyDown(KeyCode.F) && isPlayerOnShip)
            {
                Vector3 distance = other.ClosestPoint(transform.position);
                playerManager.Disembark(playerPrefab, playerSpawnPoint, distance);
                isPlayerOnShip = false;
            }
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, maxDistance);
    }
}



