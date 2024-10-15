// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqkMasterCheck_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A13")]
  public sealed class ReqkMasterCheck_ResponseFormatter : 
    IMessagePackFormatter<ReqkMasterCheck.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018B6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018B7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002787")]
    [Address(RVA = "0xEA79D0", Offset = "0xEA67D0", VA = "0x10EA79D0")]
    public ReqkMasterCheck_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002788")]
    [Address(RVA = "0xEA7880", Offset = "0xEA6680", VA = "0x10EA7880", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqkMasterCheck.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002789")]
    [Address(RVA = "0xEA7550", Offset = "0xEA6350", VA = "0x10EA7550", Slot = "5")]
    public ReqkMasterCheck.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqkMasterCheck.Response) null;
    }
  }
}
