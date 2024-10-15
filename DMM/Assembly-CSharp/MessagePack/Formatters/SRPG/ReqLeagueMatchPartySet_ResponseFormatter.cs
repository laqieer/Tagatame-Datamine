// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchPartySet_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000828")]
  public sealed class ReqLeagueMatchPartySet_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchPartySet.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014E0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014E1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021C6")]
    [Address(RVA = "0xD4FDA0", Offset = "0xD4EBA0", VA = "0x10D4FDA0")]
    public ReqLeagueMatchPartySet_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021C7")]
    [Address(RVA = "0xD4FBD0", Offset = "0xD4E9D0", VA = "0x10D4FBD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchPartySet.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021C8")]
    [Address(RVA = "0xD4F820", Offset = "0xD4E620", VA = "0x10D4F820", Slot = "5")]
    public ReqLeagueMatchPartySet.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchPartySet.Response) null;
    }
  }
}
