// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqTobiraFullMaster_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000941")]
  public sealed class FlowNode_ReqTobiraFullMaster_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqTobiraFullMaster.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001712")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001713")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002511")]
    [Address(RVA = "0xE12CD0", Offset = "0xE11AD0", VA = "0x10E12CD0")]
    public FlowNode_ReqTobiraFullMaster_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002512")]
    [Address(RVA = "0xE129E0", Offset = "0xE117E0", VA = "0x10E129E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqTobiraFullMaster.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002513")]
    [Address(RVA = "0xE125B0", Offset = "0xE113B0", VA = "0x10E125B0", Slot = "5")]
    public FlowNode_ReqTobiraFullMaster.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqTobiraFullMaster.MP_Response) null;
    }
  }
}
