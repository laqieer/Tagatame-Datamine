// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGPGSCheckRelateAccount_CheckRelateAccountResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009E6")]
  public sealed class FlowNode_ReqGPGSCheckRelateAccount_CheckRelateAccountResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGPGSCheckRelateAccount.CheckRelateAccountResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400185C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400185D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002700")]
    [Address(RVA = "0xE7E4A0", Offset = "0xE7D2A0", VA = "0x10E7E4A0")]
    public FlowNode_ReqGPGSCheckRelateAccount_CheckRelateAccountResponseFormatter()
    {
    }

    [Token(Token = "0x6002701")]
    [Address(RVA = "0xE7E1B0", Offset = "0xE7CFB0", VA = "0x10E7E1B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGPGSCheckRelateAccount.CheckRelateAccountResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002702")]
    [Address(RVA = "0xE7DD80", Offset = "0xE7CB80", VA = "0x10E7DD80", Slot = "5")]
    public FlowNode_ReqGPGSCheckRelateAccount.CheckRelateAccountResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGPGSCheckRelateAccount.CheckRelateAccountResponse) null;
    }
  }
}
