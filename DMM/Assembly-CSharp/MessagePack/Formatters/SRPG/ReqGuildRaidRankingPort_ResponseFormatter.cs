// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidRankingPort_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200093E")]
  public sealed class ReqGuildRaidRankingPort_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidRankingPort.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400170C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400170D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002508")]
    [Address(RVA = "0xE19B80", Offset = "0xE18980", VA = "0x10E19B80")]
    public ReqGuildRaidRankingPort_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002509")]
    [Address(RVA = "0xE19910", Offset = "0xE18710", VA = "0x10E19910", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidRankingPort.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600250A")]
    [Address(RVA = "0xE19590", Offset = "0xE18390", VA = "0x10E19590", Slot = "5")]
    public ReqGuildRaidRankingPort.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidRankingPort.Response) null;
    }
  }
}
