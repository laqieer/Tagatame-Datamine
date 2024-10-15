// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalSortCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006D5")]
  public sealed class JSON_CrystalSortCondParamFormatter : 
    IMessagePackFormatter<JSON_CrystalSortCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001242")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001243")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DCD")]
    [Address(RVA = "0xC13890", Offset = "0xC12690", VA = "0x10C13890")]
    public JSON_CrystalSortCondParamFormatter()
    {
    }

    [Token(Token = "0x6001DCE")]
    [Address(RVA = "0xC13670", Offset = "0xC12470", VA = "0x10C13670", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalSortCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DCF")]
    [Address(RVA = "0xC13290", Offset = "0xC12090", VA = "0x10C13290", Slot = "5")]
    public JSON_CrystalSortCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalSortCondParam) null;
    }
  }
}
