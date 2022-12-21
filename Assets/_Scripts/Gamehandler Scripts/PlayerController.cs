using UnityEngine;
using UnityEngine.InputSystem;
using Stats;

public class PlayerController : MonoBehaviour {

	private PlayerInputActions playerInputActions;
	private PauseHandler pauseHandler;

	void Start() {
		pauseHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<PauseHandler>();
		playerInputActions = new();
		playerInputActions.Player.Enable();
		playerInputActions.Player.Pause.performed += Pause;
		playerInputActions.Player.Enter.performed += Enter;
	}

	private void Update() {
		Move();
	}

	private void Move() {
		Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
		transform.Translate(Player.speed * Time.deltaTime * inputVector);
	}

	public void Pause(InputAction.CallbackContext context) {
		if (context.performed) {
			pauseHandler.pause();
		}
	}

	public void Enter(InputAction.CallbackContext context) {
		if (context.performed) {
			Debug.Log("Enter");
		}
	}
}
