// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGPresetPartyUnitsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005D4")]
  public sealed class JSON_GvGPresetPartyUnitsFormatter : 
    IMessagePackFormatter<JSON_GvGPresetPartyUnits>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001040")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001041")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001ACA")]
    [Address(RVA = "0x956FD0", Offset = "0x955DD0", VA = "0x10956FD0")]
    public JSON_GvGPresetPartyUnitsFormatter()
    {
    }

    [Token(Token = "0x6001ACB")]
    [Address(RVA = "0x956E30", Offset = "0x955C30", VA = "0x10956E30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGPresetPartyUnits value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001ACC")]
    [Address(RVA = "0x956AB0", Offset = "0x9558B0", VA = "0x10956AB0", Slot = "5")]
    public JSON_GvGPresetPartyUnits Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGPresetPartyUnits) null;
    }
  }
}
