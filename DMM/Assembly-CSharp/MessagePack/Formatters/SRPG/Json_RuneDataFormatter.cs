// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_RuneDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005B7")]
  public sealed class Json_RuneDataFormatter : 
    IMessagePackFormatter<Json_RuneData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001006")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001007")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A73")]
    [Address(RVA = "0x79F480", Offset = "0x79E280", VA = "0x1079F480")]
    public Json_RuneDataFormatter()
    {
    }

    [Token(Token = "0x6001A74")]
    [Address(RVA = "0x79F120", Offset = "0x79DF20", VA = "0x1079F120", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_RuneData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A75")]
    [Address(RVA = "0x79EC40", Offset = "0x79DA40", VA = "0x1079EC40", Slot = "5")]
    public Json_RuneData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_RuneData) null;
    }
  }
}
