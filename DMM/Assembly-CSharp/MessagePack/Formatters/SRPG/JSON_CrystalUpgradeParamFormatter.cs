// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalUpgradeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006D1")]
  public sealed class JSON_CrystalUpgradeParamFormatter : 
    IMessagePackFormatter<JSON_CrystalUpgradeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400123A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400123B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DC1")]
    [Address(RVA = "0xC15000", Offset = "0xC13E00", VA = "0x10C15000")]
    public JSON_CrystalUpgradeParamFormatter()
    {
    }

    [Token(Token = "0x6001DC2")]
    [Address(RVA = "0xC14E40", Offset = "0xC13C40", VA = "0x10C14E40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalUpgradeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DC3")]
    [Address(RVA = "0xC14AB0", Offset = "0xC138B0", VA = "0x10C14AB0", Slot = "5")]
    public JSON_CrystalUpgradeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalUpgradeParam) null;
    }
  }
}
