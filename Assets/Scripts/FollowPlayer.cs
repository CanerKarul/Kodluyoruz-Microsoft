using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Private varibles
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    
    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera behind the player by adding to player's position
        transform.position = player.transform.position + offset;
    }
}
