// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006CF")]
  public sealed class JSON_CrystalParamFormatter : 
    IMessagePackFormatter<JSON_CrystalParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001236")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001237")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DBB")]
    [Address(RVA = "0xC0F740", Offset = "0xC0E540", VA = "0x10C0F740")]
    public JSON_CrystalParamFormatter()
    {
    }

    [Token(Token = "0x6001DBC")]
    [Address(RVA = "0xC0F0D0", Offset = "0xC0DED0", VA = "0x10C0F0D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DBD")]
    [Address(RVA = "0xC0E940", Offset = "0xC0D740", VA = "0x10C0E940", Slot = "5")]
    public JSON_CrystalParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalParam) null;
    }
  }
}
