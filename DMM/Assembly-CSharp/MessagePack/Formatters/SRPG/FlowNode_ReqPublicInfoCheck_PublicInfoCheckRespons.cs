// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqPublicInfoCheck_PublicInfoCheckResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009F0")]
  public sealed class FlowNode_ReqPublicInfoCheck_PublicInfoCheckResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqPublicInfoCheck.PublicInfoCheckResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001870")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001871")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600271E")]
    [Address(RVA = "0xE80390", Offset = "0xE7F190", VA = "0x10E80390")]
    public FlowNode_ReqPublicInfoCheck_PublicInfoCheckResponseFormatter()
    {
    }

    [Token(Token = "0x600271F")]
    [Address(RVA = "0xE800A0", Offset = "0xE7EEA0", VA = "0x10E800A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqPublicInfoCheck.PublicInfoCheckResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002720")]
    [Address(RVA = "0xE7FC70", Offset = "0xE7EA70", VA = "0x10E7FC70", Slot = "5")]
    public FlowNode_ReqPublicInfoCheck.PublicInfoCheckResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqPublicInfoCheck.PublicInfoCheckResponse) null;
    }
  }
}
