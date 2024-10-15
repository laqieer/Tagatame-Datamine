// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_PlayNew_MP_PlayNewFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008E8")]
  public sealed class FlowNode_PlayNew_MP_PlayNewFormatter : 
    IMessagePackFormatter<FlowNode_PlayNew.MP_PlayNew>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001660")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001661")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002406")]
    [Address(RVA = "0xDC6A50", Offset = "0xDC5850", VA = "0x10DC6A50")]
    public FlowNode_PlayNew_MP_PlayNewFormatter()
    {
    }

    [Token(Token = "0x6002407")]
    [Address(RVA = "0xDC6760", Offset = "0xDC5560", VA = "0x10DC6760", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_PlayNew.MP_PlayNew value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002408")]
    [Address(RVA = "0xDC6330", Offset = "0xDC5130", VA = "0x10DC6330", Slot = "5")]
    public FlowNode_PlayNew.MP_PlayNew Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_PlayNew.MP_PlayNew) null;
    }
  }
}
