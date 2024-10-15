// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.SwitchAttachment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032EA")]
  public class SwitchAttachment : AnimEvent
  {
    [Token(Token = "0x400EF98")]
    [FieldOffset(Offset = "0x18")]
    public SwitchAttachment.eSwitchTarget SwitchPrimaryHand;
    [Token(Token = "0x400EF99")]
    [FieldOffset(Offset = "0x1C")]
    public SwitchAttachment.eSwitchTarget SwitchSecondaryHand;
    [Token(Token = "0x400EF9A")]
    [FieldOffset(Offset = "0x20")]
    public SwitchAttachment.eSwitchTarget SwitchTertiaryPlace;

    [Token(Token = "0x600DFA3")]
    [Address(RVA = "0xAA03C0", Offset = "0xA9F1C0", VA = "0x10AA03C0", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFA4")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public SwitchAttachment()
    {
    }

    [Token(Token = "0x20032EB")]
    public enum eSwitchTarget
    {
      [Token(Token = "0x400EF9C")] NO_CHANGE,
      [Token(Token = "0x400EF9D")] Element_0,
      [Token(Token = "0x400EF9E")] Element_1,
      [Token(Token = "0x400EF9F")] Element_2,
      [Token(Token = "0x400EFA0")] Element_3,
      [Token(Token = "0x400EFA1")] Element_4,
      [Token(Token = "0x400EFA2")] Element_5,
      [Token(Token = "0x400EFA3")] Element_6,
      [Token(Token = "0x400EFA4")] Element_7,
      [Token(Token = "0x400EFA5")] Element_8,
      [Token(Token = "0x400EFA6")] Element_9,
    }
  }
}
