// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCrystalDisassemble_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000728")]
  public sealed class FlowNode_ReqCrystalDisassemble_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCrystalDisassemble.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012E8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012E9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EC6")]
    [Address(RVA = "0xC51C20", Offset = "0xC50A20", VA = "0x10C51C20")]
    public FlowNode_ReqCrystalDisassemble_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6001EC7")]
    [Address(RVA = "0xC51930", Offset = "0xC50730", VA = "0x10C51930", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCrystalDisassemble.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EC8")]
    [Address(RVA = "0xC51500", Offset = "0xC50300", VA = "0x10C51500", Slot = "5")]
    public FlowNode_ReqCrystalDisassemble.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCrystalDisassemble.MP_Response) null;
    }
  }
}
