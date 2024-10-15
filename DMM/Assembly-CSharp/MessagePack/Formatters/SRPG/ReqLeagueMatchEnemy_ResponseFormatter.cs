// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchEnemy_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200081F")]
  public sealed class ReqLeagueMatchEnemy_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchEnemy.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014CE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014CF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021AB")]
    [Address(RVA = "0xD4DAF0", Offset = "0xD4C8F0", VA = "0x10D4DAF0")]
    public ReqLeagueMatchEnemy_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021AC")]
    [Address(RVA = "0xD4D980", Offset = "0xD4C780", VA = "0x10D4D980", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchEnemy.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021AD")]
    [Address(RVA = "0xD4D6B0", Offset = "0xD4C4B0", VA = "0x10D4D6B0", Slot = "5")]
    public ReqLeagueMatchEnemy.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchEnemy.Response) null;
    }
  }
}
