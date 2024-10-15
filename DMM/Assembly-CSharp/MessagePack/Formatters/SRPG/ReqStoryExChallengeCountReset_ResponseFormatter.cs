// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqStoryExChallengeCountReset_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A55")]
  public sealed class ReqStoryExChallengeCountReset_ResponseFormatter : 
    IMessagePackFormatter<ReqStoryExChallengeCountReset.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400193A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400193B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600284D")]
    [Address(RVA = "0xED4580", Offset = "0xED3380", VA = "0x10ED4580")]
    public ReqStoryExChallengeCountReset_ResponseFormatter()
    {
    }

    [Token(Token = "0x600284E")]
    [Address(RVA = "0xED4270", Offset = "0xED3070", VA = "0x10ED4270", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqStoryExChallengeCountReset.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600284F")]
    [Address(RVA = "0xED3EC0", Offset = "0xED2CC0", VA = "0x10ED3EC0", Slot = "5")]
    public ReqStoryExChallengeCountReset.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqStoryExChallengeCountReset.Response) null;
    }
  }
}
