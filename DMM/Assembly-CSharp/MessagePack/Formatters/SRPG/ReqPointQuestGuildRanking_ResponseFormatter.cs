// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqPointQuestGuildRanking_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200097E")]
  public sealed class ReqPointQuestGuildRanking_ResponseFormatter : 
    IMessagePackFormatter<ReqPointQuestGuildRanking.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400178C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400178D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025C8")]
    [Address(RVA = "0xE333F0", Offset = "0xE321F0", VA = "0x10E333F0")]
    public ReqPointQuestGuildRanking_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025C9")]
    [Address(RVA = "0xE33180", Offset = "0xE31F80", VA = "0x10E33180", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqPointQuestGuildRanking.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025CA")]
    [Address(RVA = "0xE32E00", Offset = "0xE31C00", VA = "0x10E32E00", Slot = "5")]
    public ReqPointQuestGuildRanking.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqPointQuestGuildRanking.Response) null;
    }
  }
}
