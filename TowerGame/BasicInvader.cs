using System;
namespace TowerGame
{
	class BasicInvader : Invader
	{
		public override int Health { get; protected set; } = 2;
		public BasicInvader(Path path) : base(path)
		{ }
	}
}
