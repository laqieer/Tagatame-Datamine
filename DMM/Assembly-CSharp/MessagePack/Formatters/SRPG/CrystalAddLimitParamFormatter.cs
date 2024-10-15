// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CrystalAddLimitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000886")]
  public sealed class CrystalAddLimitParamFormatter : 
    IMessagePackFormatter<CrystalAddLimitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400159C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400159D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022E0")]
    [Address(RVA = "0xD98CE0", Offset = "0xD97AE0", VA = "0x10D98CE0")]
    public CrystalAddLimitParamFormatter()
    {
    }

    [Token(Token = "0x60022E1")]
    [Address(RVA = "0xD98B00", Offset = "0xD97900", VA = "0x10D98B00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CrystalAddLimitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022E2")]
    [Address(RVA = "0xD987F0", Offset = "0xD975F0", VA = "0x10D987F0", Slot = "5")]
    public CrystalAddLimitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (CrystalAddLimitParam) null;
    }
  }
}
