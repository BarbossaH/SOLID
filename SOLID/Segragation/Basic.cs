using System;
namespace SOLID.Segragation
{
	public class Basic
	{
		public Basic()
		{
			//如果传入的接口有功能根本没有用到，那就是太胖了，这就违反了接口隔离原则
			//这是从用户（使用服务）的角度去说，单一职责是从提供服务的人去说
		}
	}

	class Driver
	{
		private IVehicle _vehicle;
		public Driver(IVehicle vehicle)
		{
			_vehicle = vehicle;
		}

		public void Drive()
		{
			_vehicle.Run();
		}
	}

	interface IVehicle
	{
		void Run();
	}

	class Car : IVehicle
	{
		public void Run()
		{
			Console.WriteLine("Car is running");
		}
	}

	class Truck : IVehicle
	{
		public void Run()
		{
			Console.WriteLine("Truck is running");
		}
	}

	interface IWeapon
	{
		void Fire();
	}
	interface ITank:IVehicle,IWeapon
	{
		//void Fire();
		//void Run();
	}

    class LightTank : ITank
    {
        public void Fire()
        {
			Console.WriteLine("Boom!");
        }

        public void Run()
        {
			Console.WriteLine("Light Tank is running");
        }
    }

	class MediumTank : ITank
	{
        public void Fire()
        {
            Console.WriteLine("Boom!Boom!");
        }

        public void Run()
        {
            Console.WriteLine("Medium Tank is running");
        }
    }

	class HeavyTank: ITank
	{
        public void Fire()
        {
            Console.WriteLine("Boom!Boom!Boom!");
        }

        public void Run()
        {
            Console.WriteLine("Heavy Tank is running");
        }
    }
}

