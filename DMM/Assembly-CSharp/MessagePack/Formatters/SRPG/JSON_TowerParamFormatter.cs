// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TowerParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A71")]
  public sealed class JSON_TowerParamFormatter : 
    IMessagePackFormatter<JSON_TowerParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001972")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001973")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028A1")]
    [Address(RVA = "0xECD280", Offset = "0xECC080", VA = "0x10ECD280")]
    public JSON_TowerParamFormatter()
    {
    }

    [Token(Token = "0x60028A2")]
    [Address(RVA = "0xECCBB0", Offset = "0xECB9B0", VA = "0x10ECCBB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TowerParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028A3")]
    [Address(RVA = "0xECC3A0", Offset = "0xECB1A0", VA = "0x10ECC3A0", Slot = "5")]
    public JSON_TowerParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TowerParam) null;
    }
  }
}
