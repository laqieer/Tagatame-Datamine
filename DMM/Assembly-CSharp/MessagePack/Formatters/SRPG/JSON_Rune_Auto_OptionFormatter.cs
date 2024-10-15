// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_Rune_Auto_OptionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008A6")]
  public sealed class JSON_Rune_Auto_OptionFormatter : 
    IMessagePackFormatter<JSON_Rune_Auto_Option>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015DC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015DD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002340")]
    [Address(RVA = "0xDB5A30", Offset = "0xDB4830", VA = "0x10DB5A30")]
    public JSON_Rune_Auto_OptionFormatter()
    {
    }

    [Token(Token = "0x6002341")]
    [Address(RVA = "0xDB57C0", Offset = "0xDB45C0", VA = "0x10DB57C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_Rune_Auto_Option value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002342")]
    [Address(RVA = "0xDB5440", Offset = "0xDB4240", VA = "0x10DB5440", Slot = "5")]
    public JSON_Rune_Auto_Option Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_Rune_Auto_Option) null;
    }
  }
}
