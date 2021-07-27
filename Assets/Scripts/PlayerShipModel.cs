using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipModel : MonoBehaviour
{
    private GameObject playerShipModel;
    public GameObject[] characters;

    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");

        playerShipModel = Instantiate(characters[selectedCharacter], transform.position, transform.rotation);
        playerShipModel.tag = "Player";
        
        MeshCollider shipMeshCollider = playerShipModel.AddComponent<MeshCollider>();
        shipMeshCollider.convex = true;
        shipMeshCollider.isTrigger = true;

        Rigidbody shipRigidbody = playerShipModel.AddComponent<Rigidbody>();
        shipRigidbody.isKinematic = true;
        shipRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerShipModel.transform.position = transform.position;

        playerShipModel.transform.rotation = transform.rotation;
    }

    private Quaternion flipShip(Quaternion currentRotation)
    {
        Quaternion rotation = currentRotation;
        rotation.y += 180;
        
        return rotation;
    }
}
