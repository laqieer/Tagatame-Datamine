// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGPGSRelateAccount_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000876")]
  public sealed class ReqGPGSRelateAccount_ResponseFormatter : 
    IMessagePackFormatter<ReqGPGSRelateAccount.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400157C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400157D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022B0")]
    [Address(RVA = "0xDAA540", Offset = "0xDA9340", VA = "0x10DAA540")]
    public ReqGPGSRelateAccount_ResponseFormatter()
    {
    }

    [Token(Token = "0x60022B1")]
    [Address(RVA = "0xDAA480", Offset = "0xDA9280", VA = "0x10DAA480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGPGSRelateAccount.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022B2")]
    [Address(RVA = "0xDAA1E0", Offset = "0xDA8FE0", VA = "0x10DAA1E0", Slot = "5")]
    public ReqGPGSRelateAccount.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGPGSRelateAccount.Response) null;
    }
  }
}
