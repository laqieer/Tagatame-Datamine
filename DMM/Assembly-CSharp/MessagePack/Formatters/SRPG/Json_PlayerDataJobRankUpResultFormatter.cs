// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_PlayerDataJobRankUpResultFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008A9")]
  public sealed class Json_PlayerDataJobRankUpResultFormatter : 
    IMessagePackFormatter<Json_PlayerDataJobRankUpResult>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015E2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015E3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002349")]
    [Address(RVA = "0xDC10D0", Offset = "0xDBFED0", VA = "0x10DC10D0")]
    public Json_PlayerDataJobRankUpResultFormatter()
    {
    }

    [Token(Token = "0x600234A")]
    [Address(RVA = "0xDC0E10", Offset = "0xDBFC10", VA = "0x10DC0E10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_PlayerDataJobRankUpResult value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600234B")]
    [Address(RVA = "0xDC09A0", Offset = "0xDBF7A0", VA = "0x10DC09A0", Slot = "5")]
    public Json_PlayerDataJobRankUpResult Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_PlayerDataJobRankUpResult) null;
    }
  }
}
