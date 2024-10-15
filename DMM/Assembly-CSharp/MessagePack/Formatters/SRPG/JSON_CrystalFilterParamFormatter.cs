// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalFilterParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006D8")]
  public sealed class JSON_CrystalFilterParamFormatter : 
    IMessagePackFormatter<JSON_CrystalFilterParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001248")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001249")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DD6")]
    [Address(RVA = "0xC0E670", Offset = "0xC0D470", VA = "0x10C0E670")]
    public JSON_CrystalFilterParamFormatter()
    {
    }

    [Token(Token = "0x6001DD7")]
    [Address(RVA = "0xC0E420", Offset = "0xC0D220", VA = "0x10C0E420", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalFilterParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DD8")]
    [Address(RVA = "0xC0E010", Offset = "0xC0CE10", VA = "0x10C0E010", Slot = "5")]
    public JSON_CrystalFilterParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalFilterParam) null;
    }
  }
}
