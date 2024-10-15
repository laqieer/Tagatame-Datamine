// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqSellItemAutoCheck_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AAF")]
  public sealed class ReqSellItemAutoCheck_ResponseFormatter : 
    IMessagePackFormatter<ReqSellItemAutoCheck.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019EE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019EF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600295B")]
    [Address(RVA = "0xF15F50", Offset = "0xF14D50", VA = "0x10F15F50")]
    public ReqSellItemAutoCheck_ResponseFormatter()
    {
    }

    [Token(Token = "0x600295C")]
    [Address(RVA = "0xF15E90", Offset = "0xF14C90", VA = "0x10F15E90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqSellItemAutoCheck.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600295D")]
    [Address(RVA = "0xF15BF0", Offset = "0xF149F0", VA = "0x10F15BF0", Slot = "5")]
    public ReqSellItemAutoCheck.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqSellItemAutoCheck.Response) null;
    }
  }
}
