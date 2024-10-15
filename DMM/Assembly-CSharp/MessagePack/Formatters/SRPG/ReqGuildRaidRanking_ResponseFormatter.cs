// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidRanking_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200091A")]
  public sealed class ReqGuildRaidRanking_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidRanking.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016C4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016C5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600249C")]
    [Address(RVA = "0xE04CD0", Offset = "0xE03AD0", VA = "0x10E04CD0")]
    public ReqGuildRaidRanking_ResponseFormatter()
    {
    }

    [Token(Token = "0x600249D")]
    [Address(RVA = "0xE04A60", Offset = "0xE03860", VA = "0x10E04A60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidRanking.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600249E")]
    [Address(RVA = "0xE046E0", Offset = "0xE034E0", VA = "0x10E046E0", Slot = "5")]
    public ReqGuildRaidRanking.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidRanking.Response) null;
    }
  }
}
