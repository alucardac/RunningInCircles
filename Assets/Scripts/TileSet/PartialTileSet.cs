using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FullTileSet : TileSetBase {
	[SerializeField]
	private Sprite empty = null;
	[SerializeField]
	private Sprite full = null;
	[SerializeField]
	private Sprite wall1 = null;
	[SerializeField]
	private Sprite wall2 = null;
	[SerializeField]
	private Sprite wall3 = null;
	[SerializeField]
	private Sprite wall4 = null;
	[SerializeField]
	private Sprite innerCorner1 = null;
	[SerializeField]
	private Sprite innerCorner2 = null;
	[SerializeField]
	private Sprite innerCorner3 = null;
	[SerializeField]
	private Sprite innerCorner4 = null;
	[SerializeField]
	private Sprite corner1 = null;
	[SerializeField]
	private Sprite corner2 = null;
	[SerializeField]
	private Sprite corner3 = null;
	[SerializeField]
	private Sprite corner4 = null;
	[SerializeField]
	private Sprite diagonal1 = null;
	[SerializeField]
	private Sprite diagonal2 = null;
	public Sprite GetCase(int caseIndex)
	{
		switch (caseIndex)
		{
			default:
				return full;
			case 1:
				return innerCorner1;
			case 2:
				return innerCorner2;
			case 3:
				return innerCorner3;
			case 4:
				return innerCorner4;
			case 5:
				return wall1;
			case 6:
				return wall2;
			case 7:
				return wall3;
			case 8:
				return wall4;
			case 9:
				return diagonal1;
			case 10:
				return diagonal2;
			case 11:
				return corner1;
			case 12:
				return corner2;
			case 13:
				return corner3;
			case 14:
				return corner4;
			case 15:
				return empty;
		}
	}
}