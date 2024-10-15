// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006F7")]
  public sealed class JSON_LeagueMatchRewardParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001286")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001287")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E33")]
    [Address(RVA = "0xC2B720", Offset = "0xC2A520", VA = "0x10C2B720")]
    public JSON_LeagueMatchRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001E34")]
    [Address(RVA = "0xC2B540", Offset = "0xC2A340", VA = "0x10C2B540", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E35")]
    [Address(RVA = "0xC2B200", Offset = "0xC2A000", VA = "0x10C2B200", Slot = "5")]
    public JSON_LeagueMatchRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchRewardParam) null;
    }
  }
}
