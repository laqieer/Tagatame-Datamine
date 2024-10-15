// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_RuneStateDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005B6")]
  public sealed class Json_RuneStateDataFormatter : 
    IMessagePackFormatter<Json_RuneStateData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001004")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001005")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A70")]
    [Address(RVA = "0x7A0460", Offset = "0x79F260", VA = "0x107A0460")]
    public Json_RuneStateDataFormatter()
    {
    }

    [Token(Token = "0x6001A71")]
    [Address(RVA = "0x7A0150", Offset = "0x79EF50", VA = "0x107A0150", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_RuneStateData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A72")]
    [Address(RVA = "0x79FDA0", Offset = "0x79EBA0", VA = "0x1079FDA0", Slot = "5")]
    public Json_RuneStateData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_RuneStateData) null;
    }
  }
}
