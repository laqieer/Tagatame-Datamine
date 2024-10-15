// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqPointQuestRanking_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000970")]
  public sealed class ReqPointQuestRanking_ResponseFormatter : 
    IMessagePackFormatter<ReqPointQuestRanking.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001770")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001771")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600259E")]
    [Address(RVA = "0xE34350", Offset = "0xE33150", VA = "0x10E34350")]
    public ReqPointQuestRanking_ResponseFormatter()
    {
    }

    [Token(Token = "0x600259F")]
    [Address(RVA = "0xE340E0", Offset = "0xE32EE0", VA = "0x10E340E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqPointQuestRanking.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025A0")]
    [Address(RVA = "0xE33D60", Offset = "0xE32B60", VA = "0x10E33D60", Slot = "5")]
    public ReqPointQuestRanking.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqPointQuestRanking.Response) null;
    }
  }
}
