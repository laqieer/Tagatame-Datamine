// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRunePrideUsedItems_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000914")]
  public sealed class ReqRunePrideUsedItems_ResponseFormatter : 
    IMessagePackFormatter<ReqRunePrideUsedItems.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016B8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016B9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600248A")]
    [Address(RVA = "0xE078F0", Offset = "0xE066F0", VA = "0x10E078F0")]
    public ReqRunePrideUsedItems_ResponseFormatter()
    {
    }

    [Token(Token = "0x600248B")]
    [Address(RVA = "0xE07780", Offset = "0xE06580", VA = "0x10E07780", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRunePrideUsedItems.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600248C")]
    [Address(RVA = "0xE074B0", Offset = "0xE062B0", VA = "0x10E074B0", Slot = "5")]
    public ReqRunePrideUsedItems.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRunePrideUsedItems.Response) null;
    }
  }
}
