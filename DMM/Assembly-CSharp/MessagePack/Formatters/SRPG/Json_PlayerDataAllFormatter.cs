// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_PlayerDataAllFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008A8")]
  public sealed class Json_PlayerDataAllFormatter : 
    IMessagePackFormatter<Json_PlayerDataAll>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015E0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015E1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002346")]
    [Address(RVA = "0xDBF8A0", Offset = "0xDBE6A0", VA = "0x10DBF8A0")]
    public Json_PlayerDataAllFormatter()
    {
    }

    [Token(Token = "0x6002347")]
    [Address(RVA = "0xDBE210", Offset = "0xDBD010", VA = "0x10DBE210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_PlayerDataAll value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002348")]
    [Address(RVA = "0xDBD1E0", Offset = "0xDBBFE0", VA = "0x10DBD1E0", Slot = "5")]
    public Json_PlayerDataAll Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_PlayerDataAll) null;
    }
  }
}
