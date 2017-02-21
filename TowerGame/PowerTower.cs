﻿using System;
namespace TowerGame
{
	class PowerTower : Tower
	{
		protected override int Power { get; } = 2;
		public PowerTower(MapLocation location) : base(location)
		{ }
	}
}
