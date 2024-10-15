// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqToolTipSetArtifact_MP_ArtifactSet_OverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AB3")]
  public sealed class FlowNode_ReqToolTipSetArtifact_MP_ArtifactSet_OverWriteResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqToolTipSetArtifact.MP_ArtifactSet_OverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019F6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019F7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002967")]
    [Address(RVA = "0xF0CB70", Offset = "0xF0B970", VA = "0x10F0CB70")]
    public FlowNode_ReqToolTipSetArtifact_MP_ArtifactSet_OverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x6002968")]
    [Address(RVA = "0xF0C880", Offset = "0xF0B680", VA = "0x10F0C880", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqToolTipSetArtifact.MP_ArtifactSet_OverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002969")]
    [Address(RVA = "0xF0C450", Offset = "0xF0B250", VA = "0x10F0C450", Slot = "5")]
    public FlowNode_ReqToolTipSetArtifact.MP_ArtifactSet_OverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqToolTipSetArtifact.MP_ArtifactSet_OverWriteResponse) null;
    }
  }
}
