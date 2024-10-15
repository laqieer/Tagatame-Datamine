// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchTop_LeagueMatchTopResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200081C")]
  public sealed class ReqLeagueMatchTop_LeagueMatchTopResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchTop.LeagueMatchTopResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014C8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014C9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021A2")]
    [Address(RVA = "0xD51870", Offset = "0xD50670", VA = "0x10D51870")]
    public ReqLeagueMatchTop_LeagueMatchTopResponseFormatter()
    {
    }

    [Token(Token = "0x60021A3")]
    [Address(RVA = "0xD51580", Offset = "0xD50380", VA = "0x10D51580", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchTop.LeagueMatchTopResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021A4")]
    [Address(RVA = "0xD51150", Offset = "0xD4FF50", VA = "0x10D51150", Slot = "5")]
    public ReqLeagueMatchTop.LeagueMatchTopResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchTop.LeagueMatchTopResponse) null;
    }
  }
}
