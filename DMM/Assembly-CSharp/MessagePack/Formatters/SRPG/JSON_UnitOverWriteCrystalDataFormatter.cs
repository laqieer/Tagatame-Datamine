// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitOverWriteCrystalDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005A3")]
  public sealed class JSON_UnitOverWriteCrystalDataFormatter : 
    IMessagePackFormatter<JSON_UnitOverWriteCrystalData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FDE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FDF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A37")]
    [Address(RVA = "0x795450", Offset = "0x794250", VA = "0x10795450")]
    public JSON_UnitOverWriteCrystalDataFormatter()
    {
    }

    [Token(Token = "0x6001A38")]
    [Address(RVA = "0x7951D0", Offset = "0x793FD0", VA = "0x107951D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitOverWriteCrystalData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A39")]
    [Address(RVA = "0x794D30", Offset = "0x793B30", VA = "0x10794D30", Slot = "5")]
    public JSON_UnitOverWriteCrystalData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitOverWriteCrystalData) null;
    }
  }
}
