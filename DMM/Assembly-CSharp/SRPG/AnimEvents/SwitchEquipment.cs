// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.SwitchEquipment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032EC")]
  public class SwitchEquipment : AnimEvent
  {
    [Token(Token = "0x400EFA7")]
    [FieldOffset(Offset = "0x18")]
    public SwitchEquipment.eSwitchTarget SwitchPrimaryHand;
    [Token(Token = "0x400EFA8")]
    [FieldOffset(Offset = "0x1C")]
    public SwitchEquipment.eSwitchTarget SwitchSecondaryHand;
    [Token(Token = "0x400EFA9")]
    [FieldOffset(Offset = "0x20")]
    public SwitchEquipment.eSwitchTarget SwitchTertiaryPlace;

    [Token(Token = "0x600DFA5")]
    [Address(RVA = "0xAA0490", Offset = "0xA9F290", VA = "0x10AA0490", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFA6")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public SwitchEquipment()
    {
    }

    [Token(Token = "0x20032ED")]
    public enum eSwitchTarget
    {
      [Token(Token = "0x400EFAB")] NO_CHANGE,
      [Token(Token = "0x400EFAC")] Element_0,
      [Token(Token = "0x400EFAD")] Element_1,
      [Token(Token = "0x400EFAE")] Element_2,
      [Token(Token = "0x400EFAF")] Element_3,
      [Token(Token = "0x400EFB0")] Element_4,
      [Token(Token = "0x400EFB1")] Element_5,
      [Token(Token = "0x400EFB2")] Element_6,
      [Token(Token = "0x400EFB3")] Element_7,
      [Token(Token = "0x400EFB4")] Element_8,
      [Token(Token = "0x400EFB5")] Element_9,
    }
  }
}
