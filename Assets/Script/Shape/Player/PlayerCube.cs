using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCube : Player
{
    private bool _isCubeMoving;
	private readonly float _cubeRollSpeed = 18;
    private void FixedUpdate()
    {
		if (_isCubeMoving) return;
		MovePlayer();
	}
	public override void MovePlayer()
	{
		MoveCubePlayer();
	}
    private void OnEnable()
    {
		_isCubeMoving = false;
    }
    #region CubeMover
    public void MoveCubePlayer()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		if (moveHorizontal<0) Assemble(Vector3.left);
		else if (moveHorizontal>0) Assemble(Vector3.right);
		else if (moveVertical>0) Assemble(Vector3.forward);
		else if (moveVertical<0) Assemble(Vector3.back);
	}
	private void Assemble(Vector3 dir)
	{
		var anchor = transform.position + (Vector3.down + dir) * 0.5f;
		var axis = Vector3.Cross(Vector3.up, dir);
		StartCoroutine(RollCube(anchor, axis));
	}
	IEnumerator RollCube(Vector3 anchor, Vector3 axis)
	{
		_isCubeMoving = true;
		for (int i = 0; i < (90 / _cubeRollSpeed); i++)
		{
			transform.RotateAround(anchor, axis, _cubeRollSpeed);
			yield return new WaitForSeconds(0.033f);
		}
		_isCubeMoving = false;
	}
    #endregion
}
