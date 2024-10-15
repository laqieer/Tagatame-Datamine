// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_UnitInspFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007B5")]
  public sealed class Unit_UnitInspFormatter : 
    IMessagePackFormatter<Unit.UnitInsp>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600206D")]
    [Address(RVA = "0xD0F310", Offset = "0xD0E110", VA = "0x10D0F310", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.UnitInsp value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600206E")]
    [Address(RVA = "0xD0EFC0", Offset = "0xD0DDC0", VA = "0x10D0EFC0", Slot = "5")]
    public Unit.UnitInsp Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.UnitInsp) null;
    }

    [Token(Token = "0x600206F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Unit_UnitInspFormatter()
    {
    }
  }
}
