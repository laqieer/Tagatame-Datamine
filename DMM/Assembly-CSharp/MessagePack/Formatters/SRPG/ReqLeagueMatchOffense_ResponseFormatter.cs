// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchOffense_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000823")]
  public sealed class ReqLeagueMatchOffense_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchOffense.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014D6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014D7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021B7")]
    [Address(RVA = "0xD4EBE0", Offset = "0xD4D9E0", VA = "0x10D4EBE0")]
    public ReqLeagueMatchOffense_ResponseFormatter()
    {
    }

    [Token(Token = "0x60021B8")]
    [Address(RVA = "0xD4EA10", Offset = "0xD4D810", VA = "0x10D4EA10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchOffense.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021B9")]
    [Address(RVA = "0xD4E660", Offset = "0xD4D460", VA = "0x10D4E660", Slot = "5")]
    public ReqLeagueMatchOffense.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchOffense.Response) null;
    }
  }
}
