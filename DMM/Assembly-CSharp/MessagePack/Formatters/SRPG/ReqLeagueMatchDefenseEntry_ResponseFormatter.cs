// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchDefenseEntry_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000822")]
  public sealed class ReqLeagueMatchDefenseEntry_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchDefenseEntry.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014D4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014D5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021B4")]
    [Address(RVA = "0xD4C650", Offset = "0xD4B450", VA = "0x10D4C650")]
    public ReqLeagueMatchDefenseEntry_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021B5")]
    [Address(RVA = "0xD4C550", Offset = "0xD4B350", VA = "0x10D4C550", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchDefenseEntry.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021B6")]
    [Address(RVA = "0xD4C280", Offset = "0xD4B080", VA = "0x10D4C280", Slot = "5")]
    public ReqLeagueMatchDefenseEntry.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchDefenseEntry.Response) null;
    }
  }
}
