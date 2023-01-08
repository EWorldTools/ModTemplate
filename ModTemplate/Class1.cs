using WorldLoader.Attributes;
using WorldLoader.Mods;
using HarmonyLib;

namespace Test
{
    [Mod("TestMod", "1.0", "_1254")]
    public class AppStart : UnityMod
    {
        public static UnityMod inst { get; private set; } // USE THIS TO LOG UR STUFF, Like AppStart.inst.Log(message);
        public static Harmony harmInst { get; private set; } // harmInst.Patch(typeof(class).GetMethod(nameof(class.method), AccessTools.all),
                                                             // new HarmonyMethod(typeof(patchclass).GetMethod(nameof(detourmethod), BindingFlags.NonPublic | BindingFlags.Static)));

        public override void OnInject() {
            inst = this;
            harmInst = harmonyInstance;
            inst.Log("Called OnInject!");
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName) {
            inst.Log($"[{buildIndex}] Loaded Scene - {sceneName}");
        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            inst.Log($"[{buildIndex}] Unloaded Scene - {sceneName}");
        }

        public override void OnGui() {
            // On GUI Code here
        }

        public override void OnUpdate() {
            // OnUpdate Code here
        }

        public override void OnUnload()
        {
            inst.Log("I've Been Unloadedddd Noooooo");
            // ur code here
        }
    }
}