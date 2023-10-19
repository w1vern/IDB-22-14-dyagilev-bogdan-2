using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CubeScript : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Rigidbody rigidbody;
    public int collisionRemaining = 10;
    public TMP_Text counterTextUI;
    public KeyCode jumpKeyCode;

    void Start(){
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        counterTextUI.text = "Collision counter: " + collisionRemaining;
    }

    public void toogleVisible(){
        meshRenderer.enabled ^= true;
    }

    void OnCollisionEnter(Collision col) {
        
        collisionRemaining--;
        counterTextUI.text = "Collision counter: " + collisionRemaining;
    }

    void Update(){
        if (Input.GetKeyDown(jumpKeyCode)){
            rigidbody.AddForce(Vector3.up*10, ForceMode.Impulse);
        }
    }
}
