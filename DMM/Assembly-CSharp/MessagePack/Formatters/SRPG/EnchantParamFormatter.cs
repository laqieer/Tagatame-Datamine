// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EnchantParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000766")]
  public sealed class EnchantParamFormatter : 
    IMessagePackFormatter<EnchantParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001364")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001365")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F80")]
    [Address(RVA = "0xCAD2E0", Offset = "0xCAC0E0", VA = "0x10CAD2E0")]
    public EnchantParamFormatter()
    {
    }

    [Token(Token = "0x6001F81")]
    [Address(RVA = "0xCAC5F0", Offset = "0xCAB3F0", VA = "0x10CAC5F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EnchantParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F82")]
    [Address(RVA = "0xCAB670", Offset = "0xCAA470", VA = "0x10CAB670", Slot = "5")]
    public EnchantParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EnchantParam) null;
    }
  }
}
