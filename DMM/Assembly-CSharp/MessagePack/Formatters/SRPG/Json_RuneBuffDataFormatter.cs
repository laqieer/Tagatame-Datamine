// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_RuneBuffDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005B4")]
  public sealed class Json_RuneBuffDataFormatter : 
    IMessagePackFormatter<Json_RuneBuffData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001000")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001001")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A6A")]
    [Address(RVA = "0x79EA50", Offset = "0x79D850", VA = "0x1079EA50")]
    public Json_RuneBuffDataFormatter()
    {
    }

    [Token(Token = "0x6001A6B")]
    [Address(RVA = "0x79E8F0", Offset = "0x79D6F0", VA = "0x1079E8F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_RuneBuffData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A6C")]
    [Address(RVA = "0x79E5A0", Offset = "0x79D3A0", VA = "0x1079E5A0", Slot = "5")]
    public Json_RuneBuffData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_RuneBuffData) null;
    }
  }
}
