// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_UnitFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005BE")]
  public sealed class Json_UnitFormatter : IMessagePackFormatter<Json_Unit>, IMessagePackFormatter
  {
    [Token(Token = "0x4001014")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001015")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A88")]
    [Address(RVA = "0x7A2490", Offset = "0x7A1290", VA = "0x107A2490")]
    public Json_UnitFormatter()
    {
    }

    [Token(Token = "0x6001A89")]
    [Address(RVA = "0x7A1710", Offset = "0x7A0510", VA = "0x107A1710", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Unit value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A8A")]
    [Address(RVA = "0x7A0BB0", Offset = "0x79F9B0", VA = "0x107A0BB0", Slot = "5")]
    public Json_Unit Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Unit) null;
    }
  }
}
