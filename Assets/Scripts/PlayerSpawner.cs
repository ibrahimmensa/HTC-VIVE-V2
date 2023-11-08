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
    public GameObject instantiatedPlayer;
    // Start is called before the first frame update
    void Start()
    {
        xVal = Random.Range(minX, maxX);
        zVal = Random.Range(minZ, maxZ);
        pos = new Vector3(xVal, spawnPosition.transform.position.y, zVal);
        instantiatedPlayer = PhotonNetwork.Instantiate(playerPrefab.name, pos, spawnPosition.transform.rotation);
        if (instantiatedPlayer.GetComponent<PhotonView>().IsMine)
        {
            instantiatedPlayer.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
