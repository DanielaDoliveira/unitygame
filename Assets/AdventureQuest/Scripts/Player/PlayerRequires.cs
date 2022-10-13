using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Layer;
namespace Scripts.Player
{

    [RequireComponent(typeof(PlayerController))]
    [RequireComponent(typeof(PlayerAnimation))]
    [RequireComponent(typeof(GroundChecker ))]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(PlayerSprite))]
    [RequireComponent(typeof(PlayerCollisions))]
    public class PlayerRequires : MonoBehaviour{

    }
}
