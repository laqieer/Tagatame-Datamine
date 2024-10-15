// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneDedicatedCostFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000683")]
  public sealed class JSON_RuneDedicatedCostFormatter : 
    IMessagePackFormatter<JSON_RuneDedicatedCost>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400119E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400119F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CD7")]
    [Address(RVA = "0xC02D50", Offset = "0xC01B50", VA = "0x10C02D50")]
    public JSON_RuneDedicatedCostFormatter()
    {
    }

    [Token(Token = "0x6001CD8")]
    [Address(RVA = "0xC02B00", Offset = "0xC01900", VA = "0x10C02B00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneDedicatedCost value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CD9")]
    [Address(RVA = "0xC02760", Offset = "0xC01560", VA = "0x10C02760", Slot = "5")]
    public JSON_RuneDedicatedCost Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneDedicatedCost) null;
    }
  }
}
