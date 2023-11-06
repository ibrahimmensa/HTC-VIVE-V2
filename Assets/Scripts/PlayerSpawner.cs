using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject spawnPosition;
    public float maxX, maxZ, minX, minZ;
    public Vector3 pos;
    public float xVal, zVal;
    // Start is called before the first frame update
    void Start()
    {
        xVal = Random.Range(minX, maxX);
        zVal = Random.Range(minZ, maxZ);
        pos = new Vector3(xVal, spawnPosition.transform.position.y, zVal);
        PhotonNetwork.Instantiate(playerPrefab.name, pos, spawnPosition.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
