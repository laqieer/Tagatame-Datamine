// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAdventureTimeReduce_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000943")]
  public sealed class FlowNode_ReqAdventureTimeReduce_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAdventureTimeReduce.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001716")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001717")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002517")]
    [Address(RVA = "0xE0A6C0", Offset = "0xE094C0", VA = "0x10E0A6C0")]
    public FlowNode_ReqAdventureTimeReduce_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002518")]
    [Address(RVA = "0xE0A3D0", Offset = "0xE091D0", VA = "0x10E0A3D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAdventureTimeReduce.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002519")]
    [Address(RVA = "0xE09FA0", Offset = "0xE08DA0", VA = "0x10E09FA0", Slot = "5")]
    public FlowNode_ReqAdventureTimeReduce.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAdventureTimeReduce.MP_Response) null;
    }
  }
}
