// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGBattleCapture_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008E0")]
  public sealed class FlowNode_ReqGvGBattleCapture_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGBattleCapture.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001650")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001651")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023EE")]
    [Address(RVA = "0xDC7EF0", Offset = "0xDC6CF0", VA = "0x10DC7EF0")]
    public FlowNode_ReqGvGBattleCapture_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023EF")]
    [Address(RVA = "0xDC7C00", Offset = "0xDC6A00", VA = "0x10DC7C00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGBattleCapture.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023F0")]
    [Address(RVA = "0xDC77D0", Offset = "0xDC65D0", VA = "0x10DC77D0", Slot = "5")]
    public FlowNode_ReqGvGBattleCapture.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGBattleCapture.MP_Response) null;
    }
  }
}
