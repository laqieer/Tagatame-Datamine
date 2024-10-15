// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchHistory_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200082F")]
  public sealed class ReqLeagueMatchHistory_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchHistory.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014EE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014EF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021DB")]
    [Address(RVA = "0xD7A980", Offset = "0xD79780", VA = "0x10D7A980")]
    public ReqLeagueMatchHistory_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021DC")]
    [Address(RVA = "0xD7A7A0", Offset = "0xD795A0", VA = "0x10D7A7A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchHistory.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021DD")]
    [Address(RVA = "0xD7A450", Offset = "0xD79250", VA = "0x10D7A450", Slot = "5")]
    public ReqLeagueMatchHistory.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchHistory.Response) null;
    }
  }
}
