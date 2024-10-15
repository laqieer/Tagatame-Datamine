// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchOption_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200083C")]
  public sealed class ReqLeagueMatchOption_ResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchOption.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001508")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001509")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002202")]
    [Address(RVA = "0xD7C770", Offset = "0xD7B570", VA = "0x10D7C770")]
    public ReqLeagueMatchOption_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002203")]
    [Address(RVA = "0xD7C600", Offset = "0xD7B400", VA = "0x10D7C600", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchOption.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002204")]
    [Address(RVA = "0xD7C330", Offset = "0xD7B130", VA = "0x10D7C330", Slot = "5")]
    public ReqLeagueMatchOption.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchOption.Response) null;
    }
  }
}
