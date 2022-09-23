using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepCalculator : MonoBehaviour
{
    public GameObject playerController;     // Holds the player (for player position)
    private static double stride = .70104;  // Average human stride is 2.1-2.5 feet, this is 2.3 feet in meters:
    private float previousPosition;     // Holds the previous position of the player
    private AudioSource audioSource;        // Holds the footstep audio
    public double distanceDif;              // Holds the difference between current location, and previous location
    private int counter = 1;

    // Start is called before the first frame update
    void Start()
    {
        previousPosition = playerController.GetComponent<OVRPlayerController>().Acceleration;
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null) {
            Debug.LogError("Footstep Audio not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (previousPosition > .6 && GetComponent<AudioSource>().isPlaying == false) {
            //previousPosition = playerController.transform;
            GetComponent<AudioSource>().Play();
        }
    }
}
