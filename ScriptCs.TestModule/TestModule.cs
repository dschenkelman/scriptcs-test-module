using ScriptCs.Contracts;
using System;

namespace ScriptCs.TestModule
{
    [Module("test", Extensions = "csx")]
    public class TestModule : IModule
    {
        public void Initialize(IModuleConfiguration config)
        {
            Console.WriteLine("Test module initialized");
        }
    }
}
