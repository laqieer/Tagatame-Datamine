// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_LoginBonusVipFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000869")]
  public sealed class Json_LoginBonusVipFormatter : 
    IMessagePackFormatter<Json_LoginBonusVip>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001562")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001563")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002289")]
    [Address(RVA = "0xD952A0", Offset = "0xD940A0", VA = "0x10D952A0")]
    public Json_LoginBonusVipFormatter()
    {
    }

    [Token(Token = "0x600228A")]
    [Address(RVA = "0xD951E0", Offset = "0xD93FE0", VA = "0x10D951E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_LoginBonusVip value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600228B")]
    [Address(RVA = "0xD94F40", Offset = "0xD93D40", VA = "0x10D94F40", Slot = "5")]
    public Json_LoginBonusVip Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_LoginBonusVip) null;
    }
  }
}
