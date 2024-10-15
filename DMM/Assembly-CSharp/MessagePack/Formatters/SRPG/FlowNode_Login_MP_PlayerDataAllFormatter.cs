// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_Login_MP_PlayerDataAllFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A5B")]
  public sealed class FlowNode_Login_MP_PlayerDataAllFormatter : 
    IMessagePackFormatter<FlowNode_Login.MP_PlayerDataAll>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001946")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001947")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600285F")]
    [Address(RVA = "0xEBFA80", Offset = "0xEBE880", VA = "0x10EBFA80")]
    public FlowNode_Login_MP_PlayerDataAllFormatter()
    {
    }

    [Token(Token = "0x6002860")]
    [Address(RVA = "0xEBF790", Offset = "0xEBE590", VA = "0x10EBF790", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_Login.MP_PlayerDataAll value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002861")]
    [Address(RVA = "0xEBF360", Offset = "0xEBE160", VA = "0x10EBF360", Slot = "5")]
    public FlowNode_Login.MP_PlayerDataAll Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_Login.MP_PlayerDataAll) null;
    }
  }
}
