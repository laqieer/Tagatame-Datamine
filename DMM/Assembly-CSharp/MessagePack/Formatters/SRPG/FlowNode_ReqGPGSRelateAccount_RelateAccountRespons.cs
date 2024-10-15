// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGPGSRelateAccount_RelateAccountResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000877")]
  public sealed class FlowNode_ReqGPGSRelateAccount_RelateAccountResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGPGSRelateAccount.RelateAccountResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400157E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400157F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022B3")]
    [Address(RVA = "0xD99E60", Offset = "0xD98C60", VA = "0x10D99E60")]
    public FlowNode_ReqGPGSRelateAccount_RelateAccountResponseFormatter()
    {
    }

    [Token(Token = "0x60022B4")]
    [Address(RVA = "0xD99B70", Offset = "0xD98970", VA = "0x10D99B70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGPGSRelateAccount.RelateAccountResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022B5")]
    [Address(RVA = "0xD99740", Offset = "0xD98540", VA = "0x10D99740", Slot = "5")]
    public FlowNode_ReqGPGSRelateAccount.RelateAccountResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGPGSRelateAccount.RelateAccountResponse) null;
    }
  }
}
