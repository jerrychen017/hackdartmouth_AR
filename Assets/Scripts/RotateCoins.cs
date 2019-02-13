using UnityEngine;

public class RotateCoins : MonoBehaviour {
    // Update is called once per frame
    void Update () {
        transform.Rotate(Vector3.right, Time.deltaTime * 70);
    }
}

