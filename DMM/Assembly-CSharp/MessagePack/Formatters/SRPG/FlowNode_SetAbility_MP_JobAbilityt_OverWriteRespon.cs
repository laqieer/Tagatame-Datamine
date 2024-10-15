// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_SetAbility_MP_JobAbilityt_OverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000910")]
  public sealed class FlowNode_SetAbility_MP_JobAbilityt_OverWriteResponseFormatter : 
    IMessagePackFormatter<FlowNode_SetAbility.MP_JobAbilityt_OverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016B0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016B1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600247E")]
    [Address(RVA = "0xDE0250", Offset = "0xDDF050", VA = "0x10DE0250")]
    public FlowNode_SetAbility_MP_JobAbilityt_OverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x600247F")]
    [Address(RVA = "0xDDFF60", Offset = "0xDDED60", VA = "0x10DDFF60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_SetAbility.MP_JobAbilityt_OverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002480")]
    [Address(RVA = "0xDDFB30", Offset = "0xDDE930", VA = "0x10DDFB30", Slot = "5")]
    public FlowNode_SetAbility.MP_JobAbilityt_OverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_SetAbility.MP_JobAbilityt_OverWriteResponse) null;
    }
  }
}
