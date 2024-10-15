// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_MasterCheck_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A14")]
  public sealed class FlowNode_MasterCheck_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_MasterCheck.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018B8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018B9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600278A")]
    [Address(RVA = "0xE96870", Offset = "0xE95670", VA = "0x10E96870")]
    public FlowNode_MasterCheck_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600278B")]
    [Address(RVA = "0xE96580", Offset = "0xE95380", VA = "0x10E96580", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_MasterCheck.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600278C")]
    [Address(RVA = "0xE96150", Offset = "0xE94F50", VA = "0x10E96150", Slot = "5")]
    public FlowNode_MasterCheck.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_MasterCheck.MP_Response) null;
    }
  }
}
