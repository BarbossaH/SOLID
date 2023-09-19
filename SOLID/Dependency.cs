using System;
namespace SOLID
{
	public class Dependency
	{
		public Dependency()
		{
		}
	}

	class Engine
	{
		public int RPM { get; private set; }
		public void Work(int gas)
		{
			this.RPM = 1000 * gas;
		}
	}
    // the class Car depend on Engine, which is called coupling
	// if engine class has something wrong, then Car also will occur problem
	// so if there are many classes depend on Engine class, it means these classes cannot work
	// it will influence the whole project.
    class CarDependecy
	{
		private Engine _engine;  // the class Car depend on Engine
		public CarDependecy(Engine engine)
		{
            _engine = engine;
		}

		public int Speed { get; private set; }
		public void Run(int gas)
		{
			_engine.Work(gas);
			this.Speed = _engine.RPM / 100;
		}
	}
}

