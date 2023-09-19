using System;
namespace SOLID
{
	public class AdvancedNoDependency
	{
		public AdvancedNoDependency()
		{
		}
	}
	public interface IPowerSupply
	{
		int GetPower();
	}
    //if a class has been designed, we should not modify it because this class could be used in other place
    public class PoweSupply : IPowerSupply {
		public int GetPower()
		{
			return 110;
		}
	}

    public class DeskFan
	{
		private IPowerSupply _poweSupply;
		public DeskFan(IPowerSupply poweSupply)
		{
			_poweSupply = poweSupply;
		}
		public string Work()
		{
			int power = _poweSupply.GetPower();
			if (power <= 0)
			{
				return "Won't work";
			}else if (power < 100)
			{
                return "Slow";
            }
			else if(power < 200)
			{
                return "Work fine";
			}
			else
			{
                return "Warning";
            }
        }
	}

}

