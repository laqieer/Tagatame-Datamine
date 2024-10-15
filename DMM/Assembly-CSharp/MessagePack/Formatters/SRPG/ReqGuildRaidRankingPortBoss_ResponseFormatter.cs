// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidRankingPortBoss_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008B7")]
  public sealed class ReqGuildRaidRankingPortBoss_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidRankingPortBoss.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015FE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015FF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002373")]
    [Address(RVA = "0xDC4790", Offset = "0xDC3590", VA = "0x10DC4790")]
    public ReqGuildRaidRankingPortBoss_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002374")]
    [Address(RVA = "0xDC45E0", Offset = "0xDC33E0", VA = "0x10DC45E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidRankingPortBoss.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002375")]
    [Address(RVA = "0xDC42D0", Offset = "0xDC30D0", VA = "0x10DC42D0", Slot = "5")]
    public ReqGuildRaidRankingPortBoss.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidRankingPortBoss.Response) null;
    }
  }
}
