// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.ToggleWeaponFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032F8")]
  public class ToggleWeaponFrame : AnimEvent
  {
    [Token(Token = "0x400EFD3")]
    [FieldOffset(Offset = "0x18")]
    public ToggleWeaponFrame.SHOW_TYPE Primary;
    [Token(Token = "0x400EFD4")]
    [FieldOffset(Offset = "0x1C")]
    public ToggleWeaponFrame.SHOW_TYPE Secondary;
    [Token(Token = "0x400EFD5")]
    [FieldOffset(Offset = "0x20")]
    public ToggleWeaponFrame.SHOW_TYPE Tertiary;
    [Token(Token = "0x400EFD6")]
    [FieldOffset(Offset = "0x24")]
    private UnitController mUnitController;
    [Token(Token = "0x400EFD7")]
    [FieldOffset(Offset = "0x28")]
    private GeneratedCharacter mGeneratedCharacter;

    [Token(Token = "0x600DFC8")]
    [Address(RVA = "0xAA2450", Offset = "0xAA1250", VA = "0x10AA2450", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFC9")]
    [Address(RVA = "0xAA22D0", Offset = "0xAA10D0", VA = "0x10AA22D0", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DFCA")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public ToggleWeaponFrame()
    {
    }

    [Token(Token = "0x20032F9")]
    public enum SHOW_TYPE
    {
      [Token(Token = "0x400EFD9")] KEEP,
      [Token(Token = "0x400EFDA")] HIDDEN,
      [Token(Token = "0x400EFDB")] VISIBLE,
    }
  }
}
