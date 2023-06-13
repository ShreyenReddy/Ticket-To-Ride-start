using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject DestinationCard;
    public GameObject ContentPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDrawClick()
    {
        Instantiate(DestinationCard, ContentPanel.transform, false);
    }
}
