// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_PlayerDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000723")]
  public sealed class Json_PlayerDataFormatter : 
    IMessagePackFormatter<Json_PlayerData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012DE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012DF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EB7")]
    [Address(RVA = "0xC63880", Offset = "0xC62680", VA = "0x10C63880")]
    public Json_PlayerDataFormatter()
    {
    }

    [Token(Token = "0x6001EB8")]
    [Address(RVA = "0xC623D0", Offset = "0xC611D0", VA = "0x10C623D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_PlayerData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EB9")]
    [Address(RVA = "0xC61490", Offset = "0xC60290", VA = "0x10C61490", Slot = "5")]
    public Json_PlayerData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_PlayerData) null;
    }
  }
}
