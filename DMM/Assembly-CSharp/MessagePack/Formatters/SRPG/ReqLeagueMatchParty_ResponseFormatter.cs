// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchParty_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000826")]
  public sealed class ReqLeagueMatchParty_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchParty.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014DC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014DD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021C0")]
    [Address(RVA = "0xD50F60", Offset = "0xD4FD60", VA = "0x10D50F60")]
    public ReqLeagueMatchParty_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021C1")]
    [Address(RVA = "0xD50D90", Offset = "0xD4FB90", VA = "0x10D50D90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchParty.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021C2")]
    [Address(RVA = "0xD509E0", Offset = "0xD4F7E0", VA = "0x10D509E0", Slot = "5")]
    public ReqLeagueMatchParty.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchParty.Response) null;
    }
  }
}
