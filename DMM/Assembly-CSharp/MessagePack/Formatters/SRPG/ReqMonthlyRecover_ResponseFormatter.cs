// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqMonthlyRecover_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200086F")]
  public sealed class ReqMonthlyRecover_ResponseFormatter : 
    IMessagePackFormatter<ReqMonthlyRecover.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400156E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400156F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600229B")]
    [Address(RVA = "0xDAB000", Offset = "0xDA9E00", VA = "0x10DAB000")]
    public ReqMonthlyRecover_ResponseFormatter()
    {
    }

    [Token(Token = "0x600229C")]
    [Address(RVA = "0xDAAE90", Offset = "0xDA9C90", VA = "0x10DAAE90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqMonthlyRecover.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600229D")]
    [Address(RVA = "0xDAABC0", Offset = "0xDA99C0", VA = "0x10DAABC0", Slot = "5")]
    public ReqMonthlyRecover.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqMonthlyRecover.Response) null;
    }
  }
}
