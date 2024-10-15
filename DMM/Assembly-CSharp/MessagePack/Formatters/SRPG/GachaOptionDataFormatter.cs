// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.GachaOptionDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009B4")]
  public sealed class GachaOptionDataFormatter : 
    IMessagePackFormatter<GachaOptionData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017F8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017F9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600266A")]
    [Address(RVA = "0xE39B40", Offset = "0xE38940", VA = "0x10E39B40")]
    public GachaOptionDataFormatter()
    {
    }

    [Token(Token = "0x600266B")]
    [Address(RVA = "0xE399F0", Offset = "0xE387F0", VA = "0x10E399F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      GachaOptionData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600266C")]
    [Address(RVA = "0xE39750", Offset = "0xE38550", VA = "0x10E39750", Slot = "5")]
    public GachaOptionData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (GachaOptionData) null;
    }
  }
}
