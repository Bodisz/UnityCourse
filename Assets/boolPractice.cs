using UnityEngine;
public class boolPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int ammo = 44;
        bool haveAmmo = ammo > 0;
        bool isCoolDownOver = true;

        bool canIShoot = haveAmmo && isCoolDownOver;

        int AirJumpCount = 1;
        bool isOnGround = false;
        bool canAirJump = AirJumpCount < 1;

        bool canJump = isOnGround || canAirJump;
    }
}