// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePridePotentialSlotDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200079E")]
  public sealed class RunePridePotentialSlotDataFormatter : 
    IMessagePackFormatter<RunePridePotentialSlotData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013D4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013D5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002028")]
    [Address(RVA = "0xCE0690", Offset = "0xCDF490", VA = "0x10CE0690")]
    public RunePridePotentialSlotDataFormatter()
    {
    }

    [Token(Token = "0x6002029")]
    [Address(RVA = "0xCE02D0", Offset = "0xCDF0D0", VA = "0x10CE02D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePridePotentialSlotData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600202A")]
    [Address(RVA = "0xCDFEF0", Offset = "0xCDECF0", VA = "0x10CDFEF0", Slot = "5")]
    public RunePridePotentialSlotData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePridePotentialSlotData) null;
    }
  }
}
