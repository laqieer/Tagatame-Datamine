// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchRewardItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006F6")]
  public sealed class JSON_LeagueMatchRewardItemParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchRewardItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001284")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001285")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E30")]
    [Address(RVA = "0xC2B010", Offset = "0xC29E10", VA = "0x10C2B010")]
    public JSON_LeagueMatchRewardItemParamFormatter()
    {
    }

    [Token(Token = "0x6001E31")]
    [Address(RVA = "0xC2AEB0", Offset = "0xC29CB0", VA = "0x10C2AEB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchRewardItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E32")]
    [Address(RVA = "0xC2AB60", Offset = "0xC29960", VA = "0x10C2AB60", Slot = "5")]
    public JSON_LeagueMatchRewardItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchRewardItemParam) null;
    }
  }
}
