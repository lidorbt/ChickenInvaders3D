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

        selectedCharacter = 0;

        Quaternion rotaion = transform.rotation;
        rotaion.y += 180;
        playerShipModel = Instantiate(characters[selectedCharacter], transform.position, rotaion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
