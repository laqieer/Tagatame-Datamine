// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchPartySetName_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200082A")]
  public sealed class ReqLeagueMatchPartySetName_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchPartySetName.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014E4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014E5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021CC")]
    [Address(RVA = "0xD7D5C0", Offset = "0xD7C3C0", VA = "0x10D7D5C0")]
    public ReqLeagueMatchPartySetName_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021CD")]
    [Address(RVA = "0xD7D550", Offset = "0xD7C350", VA = "0x10D7D550", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchPartySetName.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021CE")]
    [Address(RVA = "0xD7D2E0", Offset = "0xD7C0E0", VA = "0x10D7D2E0", Slot = "5")]
    public ReqLeagueMatchPartySetName.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchPartySetName.Response) null;
    }
  }
}
