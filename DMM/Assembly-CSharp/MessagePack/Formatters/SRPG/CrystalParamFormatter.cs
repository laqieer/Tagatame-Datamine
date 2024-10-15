// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CrystalParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200079A")]
  public sealed class CrystalParamFormatter : 
    IMessagePackFormatter<CrystalParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013CC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013CD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600201C")]
    [Address(RVA = "0xCD9430", Offset = "0xCD8230", VA = "0x10CD9430")]
    public CrystalParamFormatter()
    {
    }

    [Token(Token = "0x600201D")]
    [Address(RVA = "0xCD9090", Offset = "0xCD7E90", VA = "0x10CD9090", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CrystalParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600201E")]
    [Address(RVA = "0xCD8D10", Offset = "0xCD7B10", VA = "0x10CD8D10", Slot = "5")]
    public CrystalParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (CrystalParam) null;
    }
  }
}
