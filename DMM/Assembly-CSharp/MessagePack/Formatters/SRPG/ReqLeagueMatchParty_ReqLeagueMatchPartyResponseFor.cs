// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchParty_ReqLeagueMatchPartyResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000827")]
  public sealed class ReqLeagueMatchParty_ReqLeagueMatchPartyResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchParty.ReqLeagueMatchPartyResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014DE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014DF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021C3")]
    [Address(RVA = "0xD506B0", Offset = "0xD4F4B0", VA = "0x10D506B0")]
    public ReqLeagueMatchParty_ReqLeagueMatchPartyResponseFormatter()
    {
    }

    [Token(Token = "0x60021C4")]
    [Address(RVA = "0xD503C0", Offset = "0xD4F1C0", VA = "0x10D503C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchParty.ReqLeagueMatchPartyResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021C5")]
    [Address(RVA = "0xD4FF90", Offset = "0xD4ED90", VA = "0x10D4FF90", Slot = "5")]
    public ReqLeagueMatchParty.ReqLeagueMatchPartyResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchParty.ReqLeagueMatchPartyResponse) null;
    }
  }
}
