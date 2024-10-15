// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchBattleResultFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000858")]
  public sealed class JSON_LeagueMatchBattleResultFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchBattleResult>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001540")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001541")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002256")]
    [Address(RVA = "0xD8BC20", Offset = "0xD8AA20", VA = "0x10D8BC20")]
    public JSON_LeagueMatchBattleResultFormatter()
    {
    }

    [Token(Token = "0x6002257")]
    [Address(RVA = "0xD8BAD0", Offset = "0xD8A8D0", VA = "0x10D8BAD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchBattleResult value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002258")]
    [Address(RVA = "0xD8B7A0", Offset = "0xD8A5A0", VA = "0x10D8B7A0", Slot = "5")]
    public JSON_LeagueMatchBattleResult Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchBattleResult) null;
    }
  }
}
