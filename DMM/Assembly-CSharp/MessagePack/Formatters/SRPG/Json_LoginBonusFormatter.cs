// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_LoginBonusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200086A")]
  public sealed class Json_LoginBonusFormatter : 
    IMessagePackFormatter<Json_LoginBonus>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001564")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001565")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600228C")]
    [Address(RVA = "0xD93B60", Offset = "0xD92960", VA = "0x10D93B60")]
    public Json_LoginBonusFormatter()
    {
    }

    [Token(Token = "0x600228D")]
    [Address(RVA = "0xD93910", Offset = "0xD92710", VA = "0x10D93910", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_LoginBonus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600228E")]
    [Address(RVA = "0xD93570", Offset = "0xD92370", VA = "0x10D93570", Slot = "5")]
    public Json_LoginBonus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_LoginBonus) null;
    }
  }
}
