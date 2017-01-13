using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astar : MonoBehaviour {
	[SerializeField]
	private int width = 20, height = 20;
	[SerializeField]
	private LayerMask mask;

	private Grid grid;
	private Walkable walkable;

	void Start () {
		grid = new Grid (width, height);
		walkable = new Walkable (grid, mask);
	}

	void Update () {
		walkable.Reset ();
	}

	void OnDrawGizmos() {
		if (grid != null) {
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					Node n = grid.GetNode (x, y);
					if (n.IsWalkable) {
						Gizmos.color = Color.green;
					} else {
						Gizmos.color = Color.red;
					}

					Gizmos.DrawCube (n.Position, Vector3.one);
				}
			}
		}
	}
}
