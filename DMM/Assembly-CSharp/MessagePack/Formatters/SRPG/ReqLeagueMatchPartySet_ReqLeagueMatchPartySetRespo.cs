// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchPartySet_ReqLeagueMatchPartySetResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000829")]
  public sealed class ReqLeagueMatchPartySet_ReqLeagueMatchPartySetResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchPartySet.ReqLeagueMatchPartySetResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014E2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014E3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021C9")]
    [Address(RVA = "0xD4F4F0", Offset = "0xD4E2F0", VA = "0x10D4F4F0")]
    public ReqLeagueMatchPartySet_ReqLeagueMatchPartySetResponseFormatter()
    {
    }

    [Token(Token = "0x60021CA")]
    [Address(RVA = "0xD4F200", Offset = "0xD4E000", VA = "0x10D4F200", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchPartySet.ReqLeagueMatchPartySetResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021CB")]
    [Address(RVA = "0xD4EDD0", Offset = "0xD4DBD0", VA = "0x10D4EDD0", Slot = "5")]
    public ReqLeagueMatchPartySet.ReqLeagueMatchPartySetResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchPartySet.ReqLeagueMatchPartySetResponse) null;
    }
  }
}
