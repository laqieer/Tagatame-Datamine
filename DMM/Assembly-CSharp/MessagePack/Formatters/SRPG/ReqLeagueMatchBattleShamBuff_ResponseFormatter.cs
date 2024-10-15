// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchBattleShamBuff_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000839")]
  public sealed class ReqLeagueMatchBattleShamBuff_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchBattleShamBuff.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001502")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001503")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021F9")]
    [Address(RVA = "0xD79E40", Offset = "0xD78C40", VA = "0x10D79E40")]
    public ReqLeagueMatchBattleShamBuff_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021FA")]
    [Address(RVA = "0xD79D40", Offset = "0xD78B40", VA = "0x10D79D40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchBattleShamBuff.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021FB")]
    [Address(RVA = "0xD79A70", Offset = "0xD78870", VA = "0x10D79A70", Slot = "5")]
    public ReqLeagueMatchBattleShamBuff.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchBattleShamBuff.Response) null;
    }
  }
}
