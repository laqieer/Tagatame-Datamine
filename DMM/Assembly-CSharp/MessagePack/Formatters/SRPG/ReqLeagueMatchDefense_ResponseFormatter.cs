// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchDefense_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000821")]
  public sealed class ReqLeagueMatchDefense_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchDefense.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014D2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014D3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021B1")]
    [Address(RVA = "0xD4CB40", Offset = "0xD4B940", VA = "0x10D4CB40")]
    public ReqLeagueMatchDefense_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021B2")]
    [Address(RVA = "0xD4CA40", Offset = "0xD4B840", VA = "0x10D4CA40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchDefense.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021B3")]
    [Address(RVA = "0xD4C770", Offset = "0xD4B570", VA = "0x10D4C770", Slot = "5")]
    public ReqLeagueMatchDefense.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchDefense.Response) null;
    }
  }
}
