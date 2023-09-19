using System;
namespace SOLID
{
	public interface NoDependency
	{
	}

	public interface IPhone
	{
		void Dail();
		void PickUp();
		void Send();
		void Receive();
	}

    class NokiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia calling ....");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello, this is time ....");

        }

        public void Receive()
        {
            Console.WriteLine("Nokia Receiving ....");

        }

        public void Send()
        {
            Console.WriteLine("Nokia Sending ....");

        }
    }
    class EricssonPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Ericsson calling ....");

        }

        public void PickUp()
        {
            Console.WriteLine("Ericsson hello ....");

        }

        public void Receive()
        {
            Console.WriteLine("Ericsson Receive ....");

        }

        public void Send()
        {
            Console.WriteLine("Ericsson sending ....");

        }
    }

    class PhoneUser
    {
        private IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }

        public void UsePhone()
        {
            _phone.Dail();
            _phone.Send();
            _phone.Receive();
            _phone.PickUp();
        }
    }
}

