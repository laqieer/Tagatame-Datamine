// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchPartySetName_ReqLeagueMatchPartySetNameResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200082B")]
  public sealed class ReqLeagueMatchPartySetName_ReqLeagueMatchPartySetNameResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchPartySetName.ReqLeagueMatchPartySetNameResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014E6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014E7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021CF")]
    [Address(RVA = "0xD7CFB0", Offset = "0xD7BDB0", VA = "0x10D7CFB0")]
    public ReqLeagueMatchPartySetName_ReqLeagueMatchPartySetNameResponseFormatter()
    {
    }

    [Token(Token = "0x60021D0")]
    [Address(RVA = "0xD7CCC0", Offset = "0xD7BAC0", VA = "0x10D7CCC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchPartySetName.ReqLeagueMatchPartySetNameResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021D1")]
    [Address(RVA = "0xD7C890", Offset = "0xD7B690", VA = "0x10D7C890", Slot = "5")]
    public ReqLeagueMatchPartySetName.ReqLeagueMatchPartySetNameResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchPartySetName.ReqLeagueMatchPartySetNameResponse) null;
    }
  }
}
