// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAdventure_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B1F")]
  public sealed class FlowNode_ReqAdventure_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAdventure.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001ACE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001ACF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AAB")]
    [Address(RVA = "0xF32820", Offset = "0xF31620", VA = "0x10F32820")]
    public FlowNode_ReqAdventure_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AAC")]
    [Address(RVA = "0xF32530", Offset = "0xF31330", VA = "0x10F32530", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAdventure.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AAD")]
    [Address(RVA = "0xF32100", Offset = "0xF30F00", VA = "0x10F32100", Slot = "5")]
    public FlowNode_ReqAdventure.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAdventure.MP_Response) null;
    }
  }
}
