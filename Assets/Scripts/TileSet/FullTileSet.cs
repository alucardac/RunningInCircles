using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PartialTileSet : TileSetBase {
	[SerializeField]
	private Sprite empty = null;
	[SerializeField]
	private Sprite full = null;
	[SerializeField]
	private Sprite wall = null;
	[SerializeField]
	private Sprite innerCorner = null;
	[SerializeField]
	private Sprite corner = null;
	[SerializeField]
	private Sprite diagonal = null;
	public Sprite GetCase(int caseIndex)
	{
		switch (caseIndex)
		{
			default:
				return full;
			case 1:
			case 2:
			case 3:
			case 4:
				return innerCorner;
			case 5:
			case 6:
			case 7:
			case 8:
				return wall;
			case 9:
			case 10:
				return diagonal;
			case 11:
			case 12:
			case 13:
			case 14:
				return corner;
			case 15:
				return empty;
		}
	}
}
