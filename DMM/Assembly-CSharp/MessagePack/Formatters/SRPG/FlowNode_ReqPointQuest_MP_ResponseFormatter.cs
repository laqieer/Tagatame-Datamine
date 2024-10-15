// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqPointQuest_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B3D")]
  public sealed class FlowNode_ReqPointQuest_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqPointQuest.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001B0A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001B0B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002B05")]
    [Address(RVA = "0xF620B0", Offset = "0xF60EB0", VA = "0x10F620B0")]
    public FlowNode_ReqPointQuest_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002B06")]
    [Address(RVA = "0xF61DC0", Offset = "0xF60BC0", VA = "0x10F61DC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqPointQuest.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002B07")]
    [Address(RVA = "0xF61990", Offset = "0xF60790", VA = "0x10F61990", Slot = "5")]
    public FlowNode_ReqPointQuest.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqPointQuest.MP_Response) null;
    }
  }
}
