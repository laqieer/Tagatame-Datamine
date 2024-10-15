// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqLoginPack_MP_ReqLoginPackResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000736")]
  public sealed class FlowNode_ReqLoginPack_MP_ReqLoginPackResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqLoginPack.MP_ReqLoginPackResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001304")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001305")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EF0")]
    [Address(RVA = "0xC83E10", Offset = "0xC82C10", VA = "0x10C83E10")]
    public FlowNode_ReqLoginPack_MP_ReqLoginPackResponseFormatter()
    {
    }

    [Token(Token = "0x6001EF1")]
    [Address(RVA = "0xC83B20", Offset = "0xC82920", VA = "0x10C83B20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqLoginPack.MP_ReqLoginPackResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EF2")]
    [Address(RVA = "0xC836F0", Offset = "0xC824F0", VA = "0x10C836F0", Slot = "5")]
    public FlowNode_ReqLoginPack.MP_ReqLoginPackResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqLoginPack.MP_ReqLoginPackResponse) null;
    }
  }
}
