// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchRanking_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000832")]
  public sealed class ReqLeagueMatchRanking_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchRanking.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014F4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014F5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021E4")]
    [Address(RVA = "0xD7DBC0", Offset = "0xD7C9C0", VA = "0x10D7DBC0")]
    public ReqLeagueMatchRanking_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021E5")]
    [Address(RVA = "0xD7D990", Offset = "0xD7C790", VA = "0x10D7D990", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchRanking.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021E6")]
    [Address(RVA = "0xD7D650", Offset = "0xD7C450", VA = "0x10D7D650", Slot = "5")]
    public ReqLeagueMatchRanking.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchRanking.Response) null;
    }
  }
}
