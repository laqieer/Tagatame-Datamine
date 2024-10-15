// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqWorldRaidBoss_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A69")]
  public sealed class FlowNode_ReqWorldRaidBoss_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqWorldRaidBoss.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001962")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001963")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002889")]
    [Address(RVA = "0xEC4D00", Offset = "0xEC3B00", VA = "0x10EC4D00")]
    public FlowNode_ReqWorldRaidBoss_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600288A")]
    [Address(RVA = "0xEC4A10", Offset = "0xEC3810", VA = "0x10EC4A10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqWorldRaidBoss.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600288B")]
    [Address(RVA = "0xEC45E0", Offset = "0xEC33E0", VA = "0x10EC45E0", Slot = "5")]
    public FlowNode_ReqWorldRaidBoss.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqWorldRaidBoss.MP_Response) null;
    }
  }
}
