// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGPGSDisrelateAccount_DisrelateAccountResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AEF")]
  public sealed class FlowNode_ReqGPGSDisrelateAccount_DisrelateAccountResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGPGSDisrelateAccount.DisrelateAccountResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A6E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A6F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A1B")]
    [Address(RVA = "0xF1C580", Offset = "0xF1B380", VA = "0x10F1C580")]
    public FlowNode_ReqGPGSDisrelateAccount_DisrelateAccountResponseFormatter()
    {
    }

    [Token(Token = "0x6002A1C")]
    [Address(RVA = "0xF1C290", Offset = "0xF1B090", VA = "0x10F1C290", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGPGSDisrelateAccount.DisrelateAccountResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A1D")]
    [Address(RVA = "0xF1BE60", Offset = "0xF1AC60", VA = "0x10F1BE60", Slot = "5")]
    public FlowNode_ReqGPGSDisrelateAccount.DisrelateAccountResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGPGSDisrelateAccount.DisrelateAccountResponse) null;
    }
  }
}
