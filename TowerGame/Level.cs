using System;
namespace TowerGame
{
	public class Level
{
		private readonly IInvader[] _invaders;
		public Tower[] Towers { get; set; }
		public Level(IInvader[] invaders)
		{
			_invaders = invaders;
		}
		public bool Play()
		{
			int remainingInvaders = _invaders.Length;
			while (remainingInvaders > 0)
			{
				foreach (Tower tower in Towers)
				{
					tower.FireOnInvaders(_invaders);
					System.Console.WriteLine("Fire");
				}
				remainingInvaders = 0;
				foreach (IInvader invader in _invaders)
				{
					if (invader.IsActive)
					{
						invader.Move();
						System.Console.WriteLine(invader.Health);
						if (invader.HasScored)
						{
							return false;
						}
						remainingInvaders++;
					}
				}
			}
			return true;
		}
	}
}
