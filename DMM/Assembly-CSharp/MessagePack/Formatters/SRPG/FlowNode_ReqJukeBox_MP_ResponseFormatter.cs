// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqJukeBox_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B12")]
  public sealed class FlowNode_ReqJukeBox_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqJukeBox.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AB4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AB5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A84")]
    [Address(RVA = "0xF37AA0", Offset = "0xF368A0", VA = "0x10F37AA0")]
    public FlowNode_ReqJukeBox_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A85")]
    [Address(RVA = "0xF377B0", Offset = "0xF365B0", VA = "0x10F377B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqJukeBox.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A86")]
    [Address(RVA = "0xF37380", Offset = "0xF36180", VA = "0x10F37380", Slot = "5")]
    public FlowNode_ReqJukeBox.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqJukeBox.MP_Response) null;
    }
  }
}
