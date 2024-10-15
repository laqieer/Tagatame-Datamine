// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqArtifactsSet_MP_ArtifactSet_OverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009A9")]
  public sealed class FlowNode_ReqArtifactsSet_MP_ArtifactSet_OverWriteResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqArtifactsSet.MP_ArtifactSet_OverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017E2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017E3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002649")]
    [Address(RVA = "0xE37530", Offset = "0xE36330", VA = "0x10E37530")]
    public FlowNode_ReqArtifactsSet_MP_ArtifactSet_OverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x600264A")]
    [Address(RVA = "0xE37240", Offset = "0xE36040", VA = "0x10E37240", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqArtifactsSet.MP_ArtifactSet_OverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600264B")]
    [Address(RVA = "0xE36E10", Offset = "0xE35C10", VA = "0x10E36E10", Slot = "5")]
    public FlowNode_ReqArtifactsSet.MP_ArtifactSet_OverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqArtifactsSet.MP_ArtifactSet_OverWriteResponse) null;
    }
  }
}
