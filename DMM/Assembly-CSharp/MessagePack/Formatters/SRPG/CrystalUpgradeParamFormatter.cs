// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CrystalUpgradeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A48")]
  public sealed class CrystalUpgradeParamFormatter : 
    IMessagePackFormatter<CrystalUpgradeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001920")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001921")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002826")]
    [Address(RVA = "0xEA8BD0", Offset = "0xEA79D0", VA = "0x10EA8BD0")]
    public CrystalUpgradeParamFormatter()
    {
    }

    [Token(Token = "0x6002827")]
    [Address(RVA = "0xEA8A10", Offset = "0xEA7810", VA = "0x10EA8A10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CrystalUpgradeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002828")]
    [Address(RVA = "0xEA8720", Offset = "0xEA7520", VA = "0x10EA8720", Slot = "5")]
    public CrystalUpgradeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (CrystalUpgradeParam) null;
    }
  }
}
