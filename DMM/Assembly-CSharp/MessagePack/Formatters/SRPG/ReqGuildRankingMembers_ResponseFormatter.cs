// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRankingMembers_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008BD")]
  public sealed class ReqGuildRankingMembers_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRankingMembers.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400160A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400160B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002385")]
    [Address(RVA = "0xDC4D50", Offset = "0xDC3B50", VA = "0x10DC4D50")]
    public ReqGuildRankingMembers_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002386")]
    [Address(RVA = "0xDC4BE0", Offset = "0xDC39E0", VA = "0x10DC4BE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRankingMembers.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002387")]
    [Address(RVA = "0xDC4910", Offset = "0xDC3710", VA = "0x10DC4910", Slot = "5")]
    public ReqGuildRankingMembers.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRankingMembers.Response) null;
    }
  }
}
