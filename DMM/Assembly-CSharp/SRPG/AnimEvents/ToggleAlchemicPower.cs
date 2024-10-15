// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.ToggleAlchemicPower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032F0")]
  public class ToggleAlchemicPower : AnimEvent
  {
    [Token(Token = "0x400EFBB")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Color SceneFadeColor;
    [Token(Token = "0x400EFBC")]
    [FieldOffset(Offset = "0x18")]
    public bool Invert;
    [Token(Token = "0x400EFBD")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    private bool OffEmissionLine;
    [Token(Token = "0x400EFBE")]
    [FieldOffset(Offset = "0x1A")]
    [SerializeField]
    private bool OffFade;
    [Token(Token = "0x400EFBF")]
    [FieldOffset(Offset = "0x1C")]
    private UnitController mUnitController;
    [Token(Token = "0x400EFC0")]
    [FieldOffset(Offset = "0x20")]
    private GeneratedCharacter mGeneratedCharacter;
    [Token(Token = "0x400EFC1")]
    [FieldOffset(Offset = "0x24")]
    public float VesselStrength;

    [Token(Token = "0x600DFA8")]
    [Address(RVA = "0xAA0690", Offset = "0xA9F490", VA = "0x10AA0690", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFA9")]
    [Address(RVA = "0xAA05F0", Offset = "0xA9F3F0", VA = "0x10AA05F0", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DFAA")]
    [Address(RVA = "0xAA07B0", Offset = "0xA9F5B0", VA = "0x10AA07B0", Slot = "5")]
    public override void OnTick(GameObject go, float ratio)
    {
    }

    [Token(Token = "0x600DFAB")]
    [Address(RVA = "0xAA0AD0", Offset = "0xA9F8D0", VA = "0x10AA0AD0")]
    private void SetRenderMode(GameObject go, float strength)
    {
    }

    [Token(Token = "0x600DFAC")]
    [Address(RVA = "0xAA0850", Offset = "0xA9F650", VA = "0x10AA0850")]
    private void SceneFade(float strength)
    {
    }

    [Token(Token = "0x600DFAD")]
    [Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x10AA0BE0")]
    public ToggleAlchemicPower()
    {
    }

    [Token(Token = "0x600DFAE")]
    [Address(RVA = "0xAA0BB0", Offset = "0xA9F9B0", VA = "0x10AA0BB0")]
    static ToggleAlchemicPower()
    {
    }
  }
}
