// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGPartyNameSet_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008B4")]
  public sealed class FlowNode_ReqGvGPartyNameSet_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGPartyNameSet.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015F8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015F9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600236A")]
    [Address(RVA = "0xDB02D0", Offset = "0xDAF0D0", VA = "0x10DB02D0")]
    public FlowNode_ReqGvGPartyNameSet_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600236B")]
    [Address(RVA = "0xDAFFE0", Offset = "0xDAEDE0", VA = "0x10DAFFE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGPartyNameSet.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600236C")]
    [Address(RVA = "0xDAFBB0", Offset = "0xDAE9B0", VA = "0x10DAFBB0", Slot = "5")]
    public FlowNode_ReqGvGPartyNameSet.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGPartyNameSet.MP_Response) null;
    }
  }
}
