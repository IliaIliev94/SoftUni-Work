namespace ReflectionEmit
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;

    public class Program
    {
        private const string AssemblyName = "HelloStudents.dll";

        public static void Main()
        {
            var assembly = AssemblyBuilder.DefineDynamicAssembly(
                new AssemblyName(AssemblyName),
                AssemblyBuilderAccess.RunAndCollect);

            var module = assembly.DefineDynamicModule(AssemblyName);

            CreateHelloStudentsMethod(module, "GetHelloStudentsString");
            CreateSumMethod(module, "Sum");

            module.CreateGlobalFunctions();

            module.GetMethod("GetHelloStudentsString").Invoke(null, null);
            Console.WriteLine(module.GetMethod("Sum").Invoke(null, new object[] { 123, 456 }));
        }

        private static void CreateHelloStudentsMethod(ModuleBuilder module, string methodName)
        {
            var methodBuilder = module.DefineGlobalMethod(
                methodName,
                MethodAttributes.Final | MethodAttributes.Public | MethodAttributes.Static,
                typeof(void),
                new Type[0]);

            var ilGenerator = methodBuilder.GetILGenerator();

            var writeLine = typeof(Console).GetMethod(
                nameof(Console.WriteLine),
                BindingFlags.Public | BindingFlags.Static,
                Type.DefaultBinder,
                new[] { typeof(string) },
                null);

            ilGenerator.Emit(OpCodes.Ldstr, "Hello, Students!");
            ilGenerator.EmitCall(OpCodes.Call, writeLine, new[] { typeof(string) });
            ilGenerator.Emit(OpCodes.Ret);
        }

        private static void CreateSumMethod(ModuleBuilder module, string methodName)
        {
            var methodBuilder = module.DefineGlobalMethod(
                methodName,
                MethodAttributes.Final | MethodAttributes.Public | MethodAttributes.Static,
                typeof(long),
                new[] { typeof(int), typeof(int) });
            
            var ilGenerator = methodBuilder.GetILGenerator();
            
            ilGenerator.Emit(OpCodes.Ldarg_0);
            ilGenerator.Emit(OpCodes.Ldarg_1);
            ilGenerator.Emit(OpCodes.Add);
            ilGenerator.Emit(OpCodes.Conv_I8);
            ilGenerator.Emit(OpCodes.Ret);
        }

        private static long Sum(int a, int b) => a + b;
    }
}