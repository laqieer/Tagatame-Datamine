// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.ToggleUnitDisp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032F7")]
  public class ToggleUnitDisp : AnimEvent
  {
    [Token(Token = "0x400EFD1")]
    [FieldOffset(Offset = "0x18")]
    private UnitController mUnitController;
    [Token(Token = "0x400EFD2")]
    [FieldOffset(Offset = "0x1C")]
    private GeneratedCharacter mGeneratedCharacter;

    [Token(Token = "0x600DFC5")]
    [Address(RVA = "0xAA21A0", Offset = "0xAA0FA0", VA = "0x10AA21A0", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFC6")]
    [Address(RVA = "0xAA20D0", Offset = "0xAA0ED0", VA = "0x10AA20D0", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DFC7")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public ToggleUnitDisp()
    {
    }
  }
}
