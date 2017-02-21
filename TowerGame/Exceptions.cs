using System;
namespace TowerGame
{
	public class TowerGameException : System.Exception
	{                                    
	public TowerGameException()
	{

	}
	public TowerGameException(string message): base(message)
        {

	}
}
class OutofBoundsException : TowerGameException
{
	public OutofBoundsException()
	{

	}
	public OutofBoundsException(string message) : base(message)
	{

	}
}
}
