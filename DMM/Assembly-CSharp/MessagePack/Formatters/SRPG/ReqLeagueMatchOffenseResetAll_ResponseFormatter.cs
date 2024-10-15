// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchOffenseResetAll_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200083D")]
  public sealed class ReqLeagueMatchOffenseResetAll_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchOffenseResetAll.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400150A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400150B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002205")]
    [Address(RVA = "0xD7C140", Offset = "0xD7AF40", VA = "0x10D7C140")]
    public ReqLeagueMatchOffenseResetAll_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002206")]
    [Address(RVA = "0xD7BEE0", Offset = "0xD7ACE0", VA = "0x10D7BEE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchOffenseResetAll.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002207")]
    [Address(RVA = "0xD7BB30", Offset = "0xD7A930", VA = "0x10D7BB30", Slot = "5")]
    public ReqLeagueMatchOffenseResetAll.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchOffenseResetAll.Response) null;
    }
  }
}
