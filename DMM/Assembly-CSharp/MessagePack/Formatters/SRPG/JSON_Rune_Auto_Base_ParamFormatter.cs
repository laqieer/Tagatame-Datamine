// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_Rune_Auto_Base_ParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008A4")]
  public sealed class JSON_Rune_Auto_Base_ParamFormatter : 
    IMessagePackFormatter<JSON_Rune_Auto_Base_Param>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015D8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015D9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600233A")]
    [Address(RVA = "0xDB45E0", Offset = "0xDB33E0", VA = "0x10DB45E0")]
    public JSON_Rune_Auto_Base_ParamFormatter()
    {
    }

    [Token(Token = "0x600233B")]
    [Address(RVA = "0xDB44B0", Offset = "0xDB32B0", VA = "0x10DB44B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_Rune_Auto_Base_Param value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600233C")]
    [Address(RVA = "0xDB4190", Offset = "0xDB2F90", VA = "0x10DB4190", Slot = "5")]
    public JSON_Rune_Auto_Base_Param Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_Rune_Auto_Base_Param) null;
    }
  }
}
