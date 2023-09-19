using System;
namespace SOLID.Segragation
{
	public class IExapmle3
	{
		public IExapmle3()
		{
		}

	
    }

    interface IGentleman
    {
        void Love();
    }

    interface IKiller
    {
        void Kill();
    }

    class WarmKiller : IGentleman, IKiller
    {
        public void Love()
        {
            Console.WriteLine("I will love you for ever...");
        }

        //杀手不会轻易暴露自己，所以这个方法不能会随便调用，出发类的实例是IKiller
        void IKiller.Kill()
        {
            Console.WriteLine("Let me kill the enemy...");
        }
    }
}

