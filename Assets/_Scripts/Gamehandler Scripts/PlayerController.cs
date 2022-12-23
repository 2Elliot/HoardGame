using UnityEngine;
using UnityEngine.InputSystem;
using Stats;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private PlayerInputActions playerInputActions;
	private PauseHandler pauseHandler;

	public LayerMask collisionMask;

	const float skinWidth = .015f;
	public int horizontalRayCount = 4;
	public int verticalRayCount = 4;

	float horizontalRaySpacing;
	float verticalRaySpacing;

	Rigidbody2D rb;
	BoxCollider2D collider;
	RaycastOrigins raycastOrigins;

	void Start() {
		pauseHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<PauseHandler>();
		playerInputActions = new();
		playerInputActions.Player.Enable();
		playerInputActions.Player.Pause.performed += Pause;
		playerInputActions.Player.Enter.performed += Enter;
		rb = GetComponent<Rigidbody2D>();
		collider = GetComponent<BoxCollider2D>();

		CalculateRaySpacing();
	}

	void UpdateRaycastOrigins() {
		Bounds bounds = collider.bounds;
		bounds.Expand(skinWidth * -2);

		raycastOrigins.bottomLeft = new Vector2(bounds.min.x, bounds.min.y);
		raycastOrigins.bottomRight = new Vector2(bounds.max.x, bounds.min.y);
		raycastOrigins.topLeft = new Vector2(bounds.min.x, bounds.max.y);
		raycastOrigins.topRight = new Vector2(bounds.max.x, bounds.max.y);
	}

	void CalculateRaySpacing() {
		Bounds bounds = collider.bounds;
		bounds.Expand(skinWidth * -2);

		horizontalRayCount = Mathf.Clamp(horizontalRayCount, 2, int.MaxValue);
		verticalRayCount = Mathf.Clamp(verticalRayCount, 2, int.MaxValue);

		horizontalRaySpacing = bounds.size.y / (horizontalRayCount - 1);
		verticalRaySpacing = bounds.size.x / (verticalRayCount - 1);
	}

	struct RaycastOrigins {
		public Vector2 topLeft, topRight;
		public Vector2 bottomLeft, bottomRight;
	}

	private void FixedUpdate() {
		Move();
	}

	private void Move() {
		Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
		UpdateRaycastOrigins();

		if (inputVector.x != 0) {
			HorizontalCollisions(ref inputVector);
		}
		
		if (inputVector.y != 0) {
			VerticalCollisions(ref inputVector);
		}

		transform.Translate(inputVector * (PlayerStats.speed / 100));
	}

	void HorizontalCollisions(ref Vector2 inputVector) {
		float directionX = Mathf.Sign(inputVector.x);
		float rayLength = Mathf.Abs(inputVector.x) + skinWidth;

		for (int i = 0; i < horizontalRayCount; i++) {
			Vector2 rayOrigin = (directionX == -1) ? raycastOrigins.bottomLeft : raycastOrigins.bottomRight;
			rayOrigin += Vector2.up * (horizontalRaySpacing * i);
			RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.right * directionX, rayLength, collisionMask);

			Debug.DrawRay(rayOrigin, Vector2.right * directionX * rayLength, Color.red);

			if (hit) {
				inputVector.x = (hit.distance - skinWidth) * directionX;
				rayLength = hit.distance;
			}
		}
	}

	void VerticalCollisions(ref Vector2 inputVector) {
		float directionY = Mathf.Sign(inputVector.y);
		float rayLength = Mathf.Abs(inputVector.y) + skinWidth;

		for (int i = 0; i < verticalRayCount; i++) {
			Vector2 rayOrigin = (directionY == -1) ? raycastOrigins.bottomLeft : raycastOrigins.topLeft;
			rayOrigin += Vector2.right * (verticalRaySpacing * i + inputVector.x);
			RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.up * directionY, rayLength, collisionMask);

			Debug.DrawRay(rayOrigin, Vector2.up * directionY * rayLength, Color.red);

			if (hit) {
				inputVector.y = (hit.distance - skinWidth) * directionY;
				rayLength = hit.distance;
			}
		}
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
