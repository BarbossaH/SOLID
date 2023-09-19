using System.Collections;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SOLID;
using SOLID.Segragation;

//-------------------------------reflecttion 2------------------------------------
var sc = new ServiceCollection();
sc.AddScoped(typeof(ITank), typeof(HeavyTank));
//sc.AddScoped(typeof(ITank), typeof(MediumTank)); //cover the above code
sc.AddScoped<ITank, MediumTank>();
sc.AddScoped(typeof(IVehicle), typeof(MediumTank));
sc.AddScoped<Driver>();
var sp = sc.BuildServiceProvider();
//====以上是注册服务,以下就是使用依赖注入========
var driver = sp.GetService<Driver>(); //居然传入了Car对象
driver?.Drive();
ITank ? tank = sp.GetService<ITank>();
tank?.Fire();
tank?.Run();


//-------------------------------reflecttion 1------------------------------------
//ITank tank = new HeavyTank();
////=========
//var t = tank.GetType();
//object o = Activator.CreateInstance(t);
//MethodInfo fireMi = t.GetMethod("Fire");
//MethodInfo runMi = t.GetMethod("Run");
//fireMi.Invoke(o, null);
//runMi.Invoke(o, null);

//-------------------------------interface segragation3------------------------------------
#region
//var wk = new WarmKiller();
//wk.Love();
//IKiller killer = wk;
//IKiller killer2 = new WarmKiller();
//killer.Kill();
//killer2.Kill();
//var vk2 = (IGentleman)killer;
//var vk3 = (WarmKiller)killer;
//var vk4 = killer as WarmKiller;
//vk2.Love();
//vk3.Love();
//vk4.Love();
#endregion
//-------------------------------interface segragation2------------------------------------
#region
int[] nums1 = { 1, 2, 3, 4, 5 };
ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };
var nums3 = new ReadOnlyCollection(nums1);

//Console.WriteLine(Sum(nums1));
//Console.WriteLine(Sum(nums2));
//Console.WriteLine(Sum(nums3));


//foreach(var n in num3)
//{
//    Console.WriteLine(n);
//}

//static int Sum(ICollection nums) //if the paramter is ICollection, the paramter num3 won't work
//static int Sum(IEnumerable nums)
//{
//    int sum = 0;
//    foreach(var n in nums)
//    {
//        sum += (int)n;
//    }

//    return sum;
//}
#endregion
//-------------------------------interface segragation1------------------------------------
#region

//var driver = new Driver(new Car());
////driver.Drive();
//var driver1 = new Driver(new LightTank()); //这个自动过滤掉了weapon接口的方法，只关注vehicle的方法
//driver1.Drive();

#endregion

#region
var deskFan = new DeskFan(new PoweSupply());
//Console.WriteLine(deskFan.Work());
#endregion


//-------------------------------No Dependency & no coupling------------------------------------
#region
var user = new PhoneUser(new NokiaPhone());
var user1 = new PhoneUser(new EricssonPhone());
//user.UsePhone();
//user1.UsePhone();

//-------------------------------Dependency & coupling------------------------------------

var engine = new Engine();
var car = new CarDependecy(engine);
car.Run(3);
//Console.WriteLine(car.Speed);
#endregion

//-------------------------------Basic knowledge------------------------------------
//#region
//int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
//ArrayList nums2 = new ArrayList { 4, 5, 6, 7, 8 };

//#region
////static int Sum(int[] nums)
////{
////    int sum = 0;
////    foreach (var n in nums) sum += n;
////    return sum;

////}

////static double Avg(int[] nums)
////{
////    int sum = 0; double count = 0;
////    foreach(var n in nums) { sum += n;count++; }
////    return sum / count;
////}

///*
// * if I want to Sum and Avg function can deal with nums1 and nums2 at the same time,
// * I need to set the type of the parameter as IEnumerable, because int[] is a kind of array,
// * and arry is derived from IEnumerable.
// * and ArrayList is also derived from INumerable.
// * So when I'd like to use Sum and Avg function to deal with both, I need set the paramter as IEnumerable
// */
//#endregion
//static int Sum(IEnumerable nums) {
//    int sum = 0;
//    foreach(var n in nums) { sum += (int)n; }
//    return sum;
//}

//static double Avg(IEnumerable nums)
//{
//    int sum = 0;
//    int count = 0;
//    foreach(var n in nums)
//    {
//        sum += (int)n; //notice here， forced conversion of data types
//        count++;
//    }
//    return sum / count;
//}
////Console.WriteLine(Sum(nums1));
////Console.WriteLine(Avg(nums1));
////Console.WriteLine(Sum(nums2));
////Console.WriteLine(Avg(nums2));
//#endregion

