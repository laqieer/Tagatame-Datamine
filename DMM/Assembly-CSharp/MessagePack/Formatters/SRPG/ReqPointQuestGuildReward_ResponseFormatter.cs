// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqPointQuestGuildReward_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200094F")]
  public sealed class ReqPointQuestGuildReward_ResponseFormatter : 
    IMessagePackFormatter<ReqPointQuestGuildReward.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400172E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400172F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600253B")]
    [Address(RVA = "0xE1CCA0", Offset = "0xE1BAA0", VA = "0x10E1CCA0")]
    public ReqPointQuestGuildReward_ResponseFormatter()
    {
    }

    [Token(Token = "0x600253C")]
    [Address(RVA = "0xE1C3D0", Offset = "0xE1B1D0", VA = "0x10E1C3D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqPointQuestGuildReward.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600253D")]
    [Address(RVA = "0xE1BC20", Offset = "0xE1AA20", VA = "0x10E1BC20", Slot = "5")]
    public ReqPointQuestGuildReward.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqPointQuestGuildReward.Response) null;
    }
  }
}
