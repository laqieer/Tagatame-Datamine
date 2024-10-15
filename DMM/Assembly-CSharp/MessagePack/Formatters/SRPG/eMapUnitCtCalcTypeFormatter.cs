// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eMapUnitCtCalcTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000584")]
  public sealed class eMapUnitCtCalcTypeFormatter : 
    IMessagePackFormatter<eMapUnitCtCalcType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019DA")]
    [Address(RVA = "0x6B1700", Offset = "0x6B0500", VA = "0x106B1700", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eMapUnitCtCalcType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019DB")]
    [Address(RVA = "0x6B16B0", Offset = "0x6B04B0", VA = "0x106B16B0", Slot = "5")]
    public eMapUnitCtCalcType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eMapUnitCtCalcType();
    }

    [Token(Token = "0x60019DC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eMapUnitCtCalcTypeFormatter()
    {
    }
  }
}
