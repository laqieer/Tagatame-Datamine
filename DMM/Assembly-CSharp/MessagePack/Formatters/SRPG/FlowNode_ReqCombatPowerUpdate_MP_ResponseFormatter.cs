// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCombatPowerUpdate_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000936")]
  public sealed class FlowNode_ReqCombatPowerUpdate_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCombatPowerUpdate.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016FC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016FD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024F0")]
    [Address(RVA = "0xDF48B0", Offset = "0xDF36B0", VA = "0x10DF48B0")]
    public FlowNode_ReqCombatPowerUpdate_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024F1")]
    [Address(RVA = "0xDF45C0", Offset = "0xDF33C0", VA = "0x10DF45C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCombatPowerUpdate.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024F2")]
    [Address(RVA = "0xDF4190", Offset = "0xDF2F90", VA = "0x10DF4190", Slot = "5")]
    public FlowNode_ReqCombatPowerUpdate.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCombatPowerUpdate.MP_Response) null;
    }
  }
}
