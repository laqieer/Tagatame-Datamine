// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchBattleShamEntry_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000838")]
  public sealed class ReqLeagueMatchBattleShamEntry_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchBattleShamEntry.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001500")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001501")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021F6")]
    [Address(RVA = "0xD7A330", Offset = "0xD79130", VA = "0x10D7A330")]
    public ReqLeagueMatchBattleShamEntry_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021F7")]
    [Address(RVA = "0xD7A230", Offset = "0xD79030", VA = "0x10D7A230", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchBattleShamEntry.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021F8")]
    [Address(RVA = "0xD79F60", Offset = "0xD78D60", VA = "0x10D79F60", Slot = "5")]
    public ReqLeagueMatchBattleShamEntry.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchBattleShamEntry.Response) null;
    }
  }
}
