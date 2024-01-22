using UnityEngine;

public class MouveByJoystick : MonoBehaviour
{
    public Joystick joystick = null;
    public float speed = Player.Speed;
    public Rigidbody rigid_body;
    public Animator animator = null;

    // Update is called once per frame
    void Update()
    {
        Vector2 inputMouvement = joystick.Direction;
        rigid_body.velocity = new Vector3(-(inputMouvement.y * speed), rigid_body.velocity.y, inputMouvement.x * speed); // sinon d�placement invers� dans la sc�ne

        if(animator != null)
        {
            animator.SetFloat("Speed", inputMouvement.magnitude * speed);
        }
    }
}
