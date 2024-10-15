// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchOffenseResetAll_ReqLeagueMatchOffenseResetAllResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200083E")]
  public sealed class ReqLeagueMatchOffenseResetAll_ReqLeagueMatchOffenseResetAllResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchOffenseResetAll.ReqLeagueMatchOffenseResetAllResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400150C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400150D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002208")]
    [Address(RVA = "0xD7B800", Offset = "0xD7A600", VA = "0x10D7B800")]
    public ReqLeagueMatchOffenseResetAll_ReqLeagueMatchOffenseResetAllResponseFormatter()
    {
    }

    [Token(Token = "0x6002209")]
    [Address(RVA = "0xD7B510", Offset = "0xD7A310", VA = "0x10D7B510", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchOffenseResetAll.ReqLeagueMatchOffenseResetAllResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600220A")]
    [Address(RVA = "0xD7B0E0", Offset = "0xD79EE0", VA = "0x10D7B0E0", Slot = "5")]
    public ReqLeagueMatchOffenseResetAll.ReqLeagueMatchOffenseResetAllResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchOffenseResetAll.ReqLeagueMatchOffenseResetAllResponse) null;
    }
  }
}
