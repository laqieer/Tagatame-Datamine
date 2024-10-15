// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_Rune_Auto_Base_StatusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008A5")]
  public sealed class JSON_Rune_Auto_Base_StatusFormatter : 
    IMessagePackFormatter<JSON_Rune_Auto_Base_Status>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015DA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015DB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600233D")]
    [Address(RVA = "0xDB4C80", Offset = "0xDB3A80", VA = "0x10DB4C80")]
    public JSON_Rune_Auto_Base_StatusFormatter()
    {
    }

    [Token(Token = "0x600233E")]
    [Address(RVA = "0xDB4AE0", Offset = "0xDB38E0", VA = "0x10DB4AE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_Rune_Auto_Base_Status value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600233F")]
    [Address(RVA = "0xDB47D0", Offset = "0xDB35D0", VA = "0x10DB47D0", Slot = "5")]
    public JSON_Rune_Auto_Base_Status Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_Rune_Auto_Base_Status) null;
    }
  }
}
