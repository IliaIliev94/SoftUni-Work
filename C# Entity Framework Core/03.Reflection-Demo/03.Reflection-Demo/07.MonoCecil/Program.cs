namespace MonoCecil
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Mono.Cecil;
    using Mono.Cecil.Cil;

    // Try this in both Debug and Release
    public static class Program
    {
        public static void Main()
        {
            // Before
            var assembly = LoadAndDisplayAssembly("07.MonoCecil");

            // Modify the assembly
            var type = assembly.MainModule.Types.FirstOrDefault(x => x.Name == "Summator");
            var method = type.Methods.FirstOrDefault(x => x.Name == "Sum");
            var ilProcessor = method.Body.GetILProcessor();
            var addInstruction = ilProcessor.Body.Instructions.FirstOrDefault(x => x.OpCode == OpCodes.Add);
            ilProcessor.Replace(addInstruction, ilProcessor.Create(OpCodes.Sub));

            // Save the modification
            assembly.Name = new AssemblyNameDefinition("07.MonoCecil_Modified", Version.Parse("1.0"));
            assembly.Write("07.MonoCecil_Modified.dll");

            // After
            LoadAndDisplayAssembly("07.MonoCecil_Modified");
        }

        private static AssemblyDefinition LoadAndDisplayAssembly(string name)
        {
            // Read the assembly in the memory
            var assembly = AssemblyDefinition.ReadAssembly($"{name}.dll");
            var type = assembly.MainModule.Types.FirstOrDefault(x => x.Name == "Summator");
            var method = type.Methods.FirstOrDefault(x => x.Name == "Sum");
            var instructions = method.Body.Instructions;
            foreach (var instruction in instructions)
            {
                Console.WriteLine(instruction);
            }

            // Execute with reflection
            var summatorType = Assembly.LoadFrom($"{name}.dll").GetType("MonoCecil.Summator");
            var instance = Activator.CreateInstance(summatorType);
            Console.WriteLine(summatorType.GetMethod("Sum").Invoke(instance, new object[] { 10, 20 }));

            return assembly;
        }
    }
}
