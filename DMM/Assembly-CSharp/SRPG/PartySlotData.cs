// Decompiled with JetBrains decompiler
// Type: SRPG.PartySlotData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D89")]
  public class PartySlotData
  {
    [Token(Token = "0x400E361")]
    [FieldOffset(Offset = "0x8")]
    public PartySlotType Type;
    [Token(Token = "0x400E362")]
    [FieldOffset(Offset = "0xC")]
    public PartySlotIndex Index;
    [Token(Token = "0x400E363")]
    [FieldOffset(Offset = "0x10")]
    public string UnitName;
    [Token(Token = "0x400E364")]
    [FieldOffset(Offset = "0x14")]
    public bool IsSettable;

    [Token(Token = "0x600D4B7")]
    [Address(RVA = "0xA4CF60", Offset = "0xA4BD60", VA = "0x10A4CF60")]
    public PartySlotData(
      PartySlotType type,
      string unitName,
      PartySlotIndex index,
      bool isSettable = false)
    {
    }

    [Token(Token = "0x600D4B8")]
    [Address(RVA = "0xA4CD60", Offset = "0xA4BB60", VA = "0x10A4CD60", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
