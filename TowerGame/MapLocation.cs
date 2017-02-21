using System;
namespace TowerGame
{
	public class MapLocation : Point
	{
		public MapLocation(int x, int y, Map map) : base(x, y)
		{
			if (!map.OnMap(this))
			{
				throw new OutofBoundsException(this + " is outside the Map");
			}
		}
		public bool InRangeOf(MapLocation location, int range)
		{
			return DistanceTo(location) <= range;
		}
	}
}