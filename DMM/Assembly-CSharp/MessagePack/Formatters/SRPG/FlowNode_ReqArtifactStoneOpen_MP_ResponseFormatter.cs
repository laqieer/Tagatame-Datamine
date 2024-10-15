// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqArtifactStoneOpen_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A12")]
  public sealed class FlowNode_ReqArtifactStoneOpen_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqArtifactStoneOpen.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018B4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018B5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002784")]
    [Address(RVA = "0xE972D0", Offset = "0xE960D0", VA = "0x10E972D0")]
    public FlowNode_ReqArtifactStoneOpen_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002785")]
    [Address(RVA = "0xE96FE0", Offset = "0xE95DE0", VA = "0x10E96FE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqArtifactStoneOpen.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002786")]
    [Address(RVA = "0xE96BA0", Offset = "0xE959A0", VA = "0x10E96BA0", Slot = "5")]
    public FlowNode_ReqArtifactStoneOpen.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqArtifactStoneOpen.MP_Response) null;
    }
  }
}
