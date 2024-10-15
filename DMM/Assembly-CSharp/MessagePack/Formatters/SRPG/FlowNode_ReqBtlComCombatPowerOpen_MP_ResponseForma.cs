// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqBtlComCombatPowerOpen_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A24")]
  public sealed class FlowNode_ReqBtlComCombatPowerOpen_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqBtlComCombatPowerOpen.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018D8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018D9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027BA")]
    [Address(RVA = "0xE991C0", Offset = "0xE97FC0", VA = "0x10E991C0")]
    public FlowNode_ReqBtlComCombatPowerOpen_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027BB")]
    [Address(RVA = "0xE98ED0", Offset = "0xE97CD0", VA = "0x10E98ED0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqBtlComCombatPowerOpen.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027BC")]
    [Address(RVA = "0xE98AA0", Offset = "0xE978A0", VA = "0x10E98AA0", Slot = "5")]
    public FlowNode_ReqBtlComCombatPowerOpen.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqBtlComCombatPowerOpen.MP_Response) null;
    }
  }
}
