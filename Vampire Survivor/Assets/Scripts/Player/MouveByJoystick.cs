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
        rigid_body.velocity = new Vector3(-(inputMouvement.y * speed), rigid_body.velocity.y, inputMouvement.x * speed); // sinon déplacement inversé dans la scène

        if(animator != null)
        {
            animator.SetFloat("Speed", inputMouvement.magnitude * speed);
        }

        verifyPlayerPosition();
    }

    private void verifyPlayerPosition()
    {
        if (rigid_body.position.x < Globals.MinX + 50
            || rigid_body.position.y < Globals.MinY + 50
            || rigid_body.position.x > Globals.MaxX - 50
            || rigid_body.position.y > Globals.MaxY - 50)
        {
            GenerateGround.Instance.Generate();
        }
    }
}