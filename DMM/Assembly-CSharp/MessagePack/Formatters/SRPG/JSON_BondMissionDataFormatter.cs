// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BondMissionDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000946")]
  public sealed class JSON_BondMissionDataFormatter : 
    IMessagePackFormatter<JSON_BondMissionData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400171C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400171D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002520")]
    [Address(RVA = "0xE14A20", Offset = "0xE13820", VA = "0x10E14A20")]
    public JSON_BondMissionDataFormatter()
    {
    }

    [Token(Token = "0x6002521")]
    [Address(RVA = "0xE148F0", Offset = "0xE136F0", VA = "0x10E148F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BondMissionData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002522")]
    [Address(RVA = "0xE145E0", Offset = "0xE133E0", VA = "0x10E145E0", Slot = "5")]
    public JSON_BondMissionData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BondMissionData) null;
    }
  }
}
