// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MP_TrophyResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200088A")]
  public sealed class MP_TrophyResponseFormatter : 
    IMessagePackFormatter<MP_TrophyResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015A4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015A5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022EC")]
    [Address(RVA = "0xDA9EB0", Offset = "0xDA8CB0", VA = "0x10DA9EB0")]
    public MP_TrophyResponseFormatter()
    {
    }

    [Token(Token = "0x60022ED")]
    [Address(RVA = "0xDA9BC0", Offset = "0xDA89C0", VA = "0x10DA9BC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MP_TrophyResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022EE")]
    [Address(RVA = "0xDA9790", Offset = "0xDA8590", VA = "0x10DA9790", Slot = "5")]
    public MP_TrophyResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MP_TrophyResponse) null;
    }
  }
}
