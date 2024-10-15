// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureCostParam_CostFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A8A")]
  public sealed class JSON_AdventureCostParam_CostFormatter : 
    IMessagePackFormatter<JSON_AdventureCostParam.Cost>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019A4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019A5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028EC")]
    [Address(RVA = "0xED9780", Offset = "0xED8580", VA = "0x10ED9780")]
    public JSON_AdventureCostParam_CostFormatter()
    {
    }

    [Token(Token = "0x60028ED")]
    [Address(RVA = "0xED9650", Offset = "0xED8450", VA = "0x10ED9650", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureCostParam.Cost value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028EE")]
    [Address(RVA = "0xED9340", Offset = "0xED8140", VA = "0x10ED9340", Slot = "5")]
    public JSON_AdventureCostParam.Cost Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureCostParam.Cost) null;
    }
  }
}
