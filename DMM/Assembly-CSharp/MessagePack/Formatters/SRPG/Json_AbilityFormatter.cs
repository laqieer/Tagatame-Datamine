// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_AbilityFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005AD")]
  public sealed class Json_AbilityFormatter : 
    IMessagePackFormatter<Json_Ability>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FF2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FF3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A55")]
    [Address(RVA = "0x796AA0", Offset = "0x7958A0", VA = "0x10796AA0")]
    public Json_AbilityFormatter()
    {
    }

    [Token(Token = "0x6001A56")]
    [Address(RVA = "0x796930", Offset = "0x795730", VA = "0x10796930", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Ability value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A57")]
    [Address(RVA = "0x7965C0", Offset = "0x7953C0", VA = "0x107965C0", Slot = "5")]
    public Json_Ability Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Ability) null;
    }
  }
}
