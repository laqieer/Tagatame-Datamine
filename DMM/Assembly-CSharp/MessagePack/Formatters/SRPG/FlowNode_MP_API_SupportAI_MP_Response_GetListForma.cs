// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_MP_API_SupportAI_MP_Response_GetListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008D5")]
  public sealed class FlowNode_MP_API_SupportAI_MP_Response_GetListFormatter : 
    IMessagePackFormatter<FlowNode_MP_API_SupportAI.MP_Response_GetList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400163A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400163B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023CD")]
    [Address(RVA = "0xDC6000", Offset = "0xDC4E00", VA = "0x10DC6000")]
    public FlowNode_MP_API_SupportAI_MP_Response_GetListFormatter()
    {
    }

    [Token(Token = "0x60023CE")]
    [Address(RVA = "0xDC5D00", Offset = "0xDC4B00", VA = "0x10DC5D00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_MP_API_SupportAI.MP_Response_GetList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023CF")]
    [Address(RVA = "0xDC58D0", Offset = "0xDC46D0", VA = "0x10DC58D0", Slot = "5")]
    public FlowNode_MP_API_SupportAI.MP_Response_GetList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_MP_API_SupportAI.MP_Response_GetList) null;
    }
  }
}
