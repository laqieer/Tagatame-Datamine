// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalAddLimitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006DD")]
  public sealed class JSON_CrystalAddLimitParamFormatter : 
    IMessagePackFormatter<JSON_CrystalAddLimitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001252")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001253")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DE5")]
    [Address(RVA = "0xC25220", Offset = "0xC24020", VA = "0x10C25220")]
    public JSON_CrystalAddLimitParamFormatter()
    {
    }

    [Token(Token = "0x6001DE6")]
    [Address(RVA = "0xC25040", Offset = "0xC23E40", VA = "0x10C25040", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalAddLimitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DE7")]
    [Address(RVA = "0xC24D00", Offset = "0xC23B00", VA = "0x10C24D00", Slot = "5")]
    public JSON_CrystalAddLimitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalAddLimitParam) null;
    }
  }
}
