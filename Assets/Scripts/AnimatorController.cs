using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public enum PlayerState { IDLE, RUN, JUMPING}
public class AnimatorController : MonoBehaviour
{
    //private Animator _animator;
    //private MarioScript _movement;
    //private SpriteRenderer _rend;
    //private PlayerState _currentState;
    // Start is called before the first frame update
    void Start()
    {
        //_animator = GetComponent<Animator>();
        //_movement = GetComponent<MarioScript>();
        //_rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //switch( _movement.GetCurrentState())
        //{
        //    case PlayerState.IDLE:
        //        _animator.SetBool("RUN", false); 
        //        break;
        //    case PlayerState.RUN:
        //        _animator.SetBool("RUN", true);
        //        break;
        //    case PlayerState.JUMPING:
        //        _animator.Play("JUMPING");
        //        break;
        //}
    }

    //public PlayerState GetCurrentState()
    //{
    //    return _currentState;
    //}
}
