// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalUpgradeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008CF")]
  public sealed class JSON_CrystalUpgradeFormatter : 
    IMessagePackFormatter<JSON_CrystalUpgrade>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400162E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400162F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023BB")]
    [Address(RVA = "0xDCDE00", Offset = "0xDCCC00", VA = "0x10DCDE00")]
    public JSON_CrystalUpgradeFormatter()
    {
    }

    [Token(Token = "0x60023BC")]
    [Address(RVA = "0xDCDCD0", Offset = "0xDCCAD0", VA = "0x10DCDCD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalUpgrade value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023BD")]
    [Address(RVA = "0xDCD9A0", Offset = "0xDCC7A0", VA = "0x10DCD9A0", Slot = "5")]
    public JSON_CrystalUpgrade Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalUpgrade) null;
    }
  }
}
