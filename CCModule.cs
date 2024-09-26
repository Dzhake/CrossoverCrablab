using System;

namespace Celeste.Mod.CrossoverCrablab;

public class CCModule : EverestModule {
    public static CCModule Instance { get; private set; }

    public override Type SessionType => typeof(CCSession);
    public static CCSession Session => (CCSession) Instance._Session;

    public override Type SaveDataType => typeof(CCSaveData);
    public static CCSaveData SaveData => (CCSaveData) Instance._SaveData;

    public CCModule()
    {
        Instance = this;
    }

    public override void Load()
    {
        CCHooks.Load();
    }

    public override void Unload()
    {
        CCHooks.Unload();
    }
}