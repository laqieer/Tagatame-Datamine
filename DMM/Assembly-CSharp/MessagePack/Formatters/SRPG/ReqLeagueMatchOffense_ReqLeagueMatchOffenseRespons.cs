// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchOffense_ReqLeagueMatchOffenseResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000824")]
  public sealed class ReqLeagueMatchOffense_ReqLeagueMatchOffenseResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchOffense.ReqLeagueMatchOffenseResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014D8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014D9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021BA")]
    [Address(RVA = "0xD4E330", Offset = "0xD4D130", VA = "0x10D4E330")]
    public ReqLeagueMatchOffense_ReqLeagueMatchOffenseResponseFormatter()
    {
    }

    [Token(Token = "0x60021BB")]
    [Address(RVA = "0xD4E040", Offset = "0xD4CE40", VA = "0x10D4E040", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchOffense.ReqLeagueMatchOffenseResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021BC")]
    [Address(RVA = "0xD4DC10", Offset = "0xD4CA10", VA = "0x10D4DC10", Slot = "5")]
    public ReqLeagueMatchOffense.ReqLeagueMatchOffenseResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchOffense.ReqLeagueMatchOffenseResponse) null;
    }
  }
}
