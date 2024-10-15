// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eMapBreakRayTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200058C")]
  public sealed class eMapBreakRayTypeFormatter : 
    IMessagePackFormatter<eMapBreakRayType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019F2")]
    [Address(RVA = "0x7A4E10", Offset = "0x7A3C10", VA = "0x107A4E10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eMapBreakRayType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019F3")]
    [Address(RVA = "0x7A4DC0", Offset = "0x7A3BC0", VA = "0x107A4DC0", Slot = "5")]
    public eMapBreakRayType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eMapBreakRayType();
    }

    [Token(Token = "0x60019F4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eMapBreakRayTypeFormatter()
    {
    }
  }
}
