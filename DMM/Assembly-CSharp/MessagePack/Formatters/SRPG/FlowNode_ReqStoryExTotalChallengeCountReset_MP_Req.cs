// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqStoryExTotalChallengeCountReset_MP_ReqStoryExChallengeCountResetResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A56")]
  public sealed class FlowNode_ReqStoryExTotalChallengeCountReset_MP_ReqStoryExChallengeCountResetResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqStoryExTotalChallengeCountReset.MP_ReqStoryExChallengeCountResetResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400193C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400193D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002850")]
    [Address(RVA = "0xEC42B0", Offset = "0xEC30B0", VA = "0x10EC42B0")]
    public FlowNode_ReqStoryExTotalChallengeCountReset_MP_ReqStoryExChallengeCountResetResponseFormatter()
    {
    }

    [Token(Token = "0x6002851")]
    [Address(RVA = "0xEC3FC0", Offset = "0xEC2DC0", VA = "0x10EC3FC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqStoryExTotalChallengeCountReset.MP_ReqStoryExChallengeCountResetResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002852")]
    [Address(RVA = "0xEC3B90", Offset = "0xEC2990", VA = "0x10EC3B90", Slot = "5")]
    public FlowNode_ReqStoryExTotalChallengeCountReset.MP_ReqStoryExChallengeCountResetResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqStoryExTotalChallengeCountReset.MP_ReqStoryExChallengeCountResetResponse) null;
    }
  }
}
