// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneDedicatedCostItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000682")]
  public sealed class JSON_RuneDedicatedCostItemFormatter : 
    IMessagePackFormatter<JSON_RuneDedicatedCostItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400119C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400119D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CD4")]
    [Address(RVA = "0xC033F0", Offset = "0xC021F0", VA = "0x10C033F0")]
    public JSON_RuneDedicatedCostItemFormatter()
    {
    }

    [Token(Token = "0x6001CD5")]
    [Address(RVA = "0xC032C0", Offset = "0xC020C0", VA = "0x10C032C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneDedicatedCostItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CD6")]
    [Address(RVA = "0xC02FB0", Offset = "0xC01DB0", VA = "0x10C02FB0", Slot = "5")]
    public JSON_RuneDedicatedCostItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneDedicatedCostItem) null;
    }
  }
}
