// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqPointQuestGuildPersonRanking_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000954")]
  public sealed class ReqPointQuestGuildPersonRanking_ResponseFormatter : 
    IMessagePackFormatter<ReqPointQuestGuildPersonRanking.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001738")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001739")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600254A")]
    [Address(RVA = "0xE1BAA0", Offset = "0xE1A8A0", VA = "0x10E1BAA0")]
    public ReqPointQuestGuildPersonRanking_ResponseFormatter()
    {
    }

    [Token(Token = "0x600254B")]
    [Address(RVA = "0xE1B870", Offset = "0xE1A670", VA = "0x10E1B870", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqPointQuestGuildPersonRanking.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600254C")]
    [Address(RVA = "0xE1B530", Offset = "0xE1A330", VA = "0x10E1B530", Slot = "5")]
    public ReqPointQuestGuildPersonRanking.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqPointQuestGuildPersonRanking.Response) null;
    }
  }
}
