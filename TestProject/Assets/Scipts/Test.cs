using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int _intplayerHealth = 100;

    public void Start() {

    }

    /* Rigidbody _pl;
    
    float _walkspeed;
    float _inputHori;
    float _inputVert;

    void Start()
    {
        _pl = gameObject.GetComponent<Rigidbody>();
        _walkspeed = 5.5f;
    }

    void Update()
    {
        _inputHori = Input.GetAxisRaw("Horizontal");
        _inputVert = Input.GetAxisRaw("Vertical");

        if (_inputHori != 0) {
            _pl.AddForce(new Vector2(_inputHori*_walkspeed, 0f));
        }
        if (_inputVert != 0) {
            _pl.AddForce(new Vector2(0f, _inputVert*_walkspeed));
        }
    }  */
}
