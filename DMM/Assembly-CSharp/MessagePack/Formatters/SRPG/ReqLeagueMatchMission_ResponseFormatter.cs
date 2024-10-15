// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchMission_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200083A")]
  public sealed class ReqLeagueMatchMission_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchMission.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001504")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001505")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021FC")]
    [Address(RVA = "0xD7AFC0", Offset = "0xD79DC0", VA = "0x10D7AFC0")]
    public ReqLeagueMatchMission_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021FD")]
    [Address(RVA = "0xD7AE40", Offset = "0xD79C40", VA = "0x10D7AE40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchMission.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021FE")]
    [Address(RVA = "0xD7AB70", Offset = "0xD79970", VA = "0x10D7AB70", Slot = "5")]
    public ReqLeagueMatchMission.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchMission.Response) null;
    }
  }
}
