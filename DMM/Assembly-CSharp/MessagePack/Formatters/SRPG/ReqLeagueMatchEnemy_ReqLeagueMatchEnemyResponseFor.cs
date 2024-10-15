// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchEnemy_ReqLeagueMatchEnemyResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000820")]
  public sealed class ReqLeagueMatchEnemy_ReqLeagueMatchEnemyResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchEnemy.ReqLeagueMatchEnemyResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014D0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014D1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021AE")]
    [Address(RVA = "0xD4D380", Offset = "0xD4C180", VA = "0x10D4D380")]
    public ReqLeagueMatchEnemy_ReqLeagueMatchEnemyResponseFormatter()
    {
    }

    [Token(Token = "0x60021AF")]
    [Address(RVA = "0xD4D090", Offset = "0xD4BE90", VA = "0x10D4D090", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchEnemy.ReqLeagueMatchEnemyResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021B0")]
    [Address(RVA = "0xD4CC60", Offset = "0xD4BA60", VA = "0x10D4CC60", Slot = "5")]
    public ReqLeagueMatchEnemy.ReqLeagueMatchEnemyResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchEnemy.ReqLeagueMatchEnemyResponse) null;
    }
  }
}
