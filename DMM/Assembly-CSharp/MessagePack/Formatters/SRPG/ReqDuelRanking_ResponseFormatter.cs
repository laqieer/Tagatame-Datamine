// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqDuelRanking_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A5E")]
  public sealed class ReqDuelRanking_ResponseFormatter : 
    IMessagePackFormatter<ReqDuelRanking.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400194C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400194D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002868")]
    [Address(RVA = "0xED2330", Offset = "0xED1130", VA = "0x10ED2330")]
    public ReqDuelRanking_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002869")]
    [Address(RVA = "0xED2120", Offset = "0xED0F20", VA = "0x10ED2120", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqDuelRanking.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600286A")]
    [Address(RVA = "0xED1DA0", Offset = "0xED0BA0", VA = "0x10ED1DA0", Slot = "5")]
    public ReqDuelRanking.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqDuelRanking.Response) null;
    }
  }
}
