// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqLoginPack_JSON_ReqLoginPackResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000735")]
  public sealed class FlowNode_ReqLoginPack_JSON_ReqLoginPackResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqLoginPack.JSON_ReqLoginPackResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001302")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001303")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EED")]
    [Address(RVA = "0xC83210", Offset = "0xC82010", VA = "0x10C83210")]
    public FlowNode_ReqLoginPack_JSON_ReqLoginPackResponseFormatter()
    {
    }

    [Token(Token = "0x6001EEE")]
    [Address(RVA = "0xC82BF0", Offset = "0xC819F0", VA = "0x10C82BF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqLoginPack.JSON_ReqLoginPackResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EEF")]
    [Address(RVA = "0xC82620", Offset = "0xC81420", VA = "0x10C82620", Slot = "5")]
    public FlowNode_ReqLoginPack.JSON_ReqLoginPackResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqLoginPack.JSON_ReqLoginPackResponse) null;
    }
  }
}
