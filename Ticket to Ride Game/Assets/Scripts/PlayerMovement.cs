using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int PlayerScore;
    public GameObject PlayerPiece;
    public GameObject[] Blocks;
    public Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        Target = Blocks[PlayerScore - 1].transform;

    }

    // Update is called once per frame
    void Update()
    {
        PlayerPiece.transform.position = Vector2.MoveTowards(PlayerPiece.transform.position, Target.position, 0.5f * Time.deltaTime);
    }
}
