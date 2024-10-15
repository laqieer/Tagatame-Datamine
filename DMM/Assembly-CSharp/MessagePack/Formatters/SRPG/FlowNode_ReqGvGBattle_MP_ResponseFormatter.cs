// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGBattle_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200094E")]
  public sealed class FlowNode_ReqGvGBattle_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGBattle.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400172C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400172D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002538")]
    [Address(RVA = "0xE0F940", Offset = "0xE0E740", VA = "0x10E0F940")]
    public FlowNode_ReqGvGBattle_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002539")]
    [Address(RVA = "0xE0F650", Offset = "0xE0E450", VA = "0x10E0F650", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGBattle.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600253A")]
    [Address(RVA = "0xE0F220", Offset = "0xE0E020", VA = "0x10E0F220", Slot = "5")]
    public FlowNode_ReqGvGBattle.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGBattle.MP_Response) null;
    }
  }
}
