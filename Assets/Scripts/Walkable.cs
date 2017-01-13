using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkable 
{
	private Grid grid;
	private LayerMask mask;

	public Walkable (Grid grid, LayerMask mask){
		this.grid = grid;
		this.mask = mask;

		Reset ();
	}

	public void Reset() {
		for (int x = 0; x < grid.Width; x++) {
			for (int y = 0; y < grid.Height; y++) {
				bool isWalkable = !Physics.CheckSphere(new Vector2(x, y), .45f, mask);
				grid.GetNode (x, y).IsWalkable = isWalkable;
			}
		}
	}
}
