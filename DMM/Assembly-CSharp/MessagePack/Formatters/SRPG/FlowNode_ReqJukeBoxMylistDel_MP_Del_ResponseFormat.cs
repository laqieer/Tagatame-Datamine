// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqJukeBoxMylistDel_MP_Del_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AA8")]
  public sealed class FlowNode_ReqJukeBoxMylistDel_MP_Del_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqJukeBoxMylistDel.MP_Del_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019E0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019E1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002946")]
    [Address(RVA = "0xEEDEC0", Offset = "0xEECCC0", VA = "0x10EEDEC0")]
    public FlowNode_ReqJukeBoxMylistDel_MP_Del_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002947")]
    [Address(RVA = "0xEEDBD0", Offset = "0xEEC9D0", VA = "0x10EEDBD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqJukeBoxMylistDel.MP_Del_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002948")]
    [Address(RVA = "0xEED7A0", Offset = "0xEEC5A0", VA = "0x10EED7A0", Slot = "5")]
    public FlowNode_ReqJukeBoxMylistDel.MP_Del_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqJukeBoxMylistDel.MP_Del_Response) null;
    }
  }
}
