// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqUnitRentalLeave_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009BA")]
  public sealed class ReqUnitRentalLeave_ResponseFormatter : 
    IMessagePackFormatter<ReqUnitRentalLeave.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001804")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001805")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600267C")]
    [Address(RVA = "0xE7AA40", Offset = "0xE79840", VA = "0x10E7AA40")]
    public ReqUnitRentalLeave_ResponseFormatter()
    {
    }

    [Token(Token = "0x600267D")]
    [Address(RVA = "0xE7A880", Offset = "0xE79680", VA = "0x10E7A880", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqUnitRentalLeave.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600267E")]
    [Address(RVA = "0xE7A4E0", Offset = "0xE792E0", VA = "0x10E7A4E0", Slot = "5")]
    public ReqUnitRentalLeave.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqUnitRentalLeave.Response) null;
    }
  }
}
