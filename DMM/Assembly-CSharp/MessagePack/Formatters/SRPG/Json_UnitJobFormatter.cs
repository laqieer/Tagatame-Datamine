// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_UnitJobFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005B1")]
  public sealed class Json_UnitJobFormatter : 
    IMessagePackFormatter<Json_UnitJob>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FFA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FFB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A61")]
    [Address(RVA = "0x7A34E0", Offset = "0x7A22E0", VA = "0x107A34E0")]
    public Json_UnitJobFormatter()
    {
    }

    [Token(Token = "0x6001A62")]
    [Address(RVA = "0x7A33B0", Offset = "0x7A21B0", VA = "0x107A33B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_UnitJob value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A63")]
    [Address(RVA = "0x7A3080", Offset = "0x7A1E80", VA = "0x107A3080", Slot = "5")]
    public Json_UnitJob Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_UnitJob) null;
    }
  }
}
