// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqOverWriteParty_MP_OverWritePartyResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AAC")]
  public sealed class FlowNode_ReqOverWriteParty_MP_OverWritePartyResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqOverWriteParty.MP_OverWritePartyResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019E8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019E9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002952")]
    [Address(RVA = "0xEEE910", Offset = "0xEED710", VA = "0x10EEE910")]
    public FlowNode_ReqOverWriteParty_MP_OverWritePartyResponseFormatter()
    {
    }

    [Token(Token = "0x6002953")]
    [Address(RVA = "0xEEE620", Offset = "0xEED420", VA = "0x10EEE620", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqOverWriteParty.MP_OverWritePartyResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002954")]
    [Address(RVA = "0xEEE1F0", Offset = "0xEECFF0", VA = "0x10EEE1F0", Slot = "5")]
    public FlowNode_ReqOverWriteParty.MP_OverWritePartyResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqOverWriteParty.MP_OverWritePartyResponse) null;
    }
  }
}
