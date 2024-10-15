// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneSetEffFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000680")]
  public sealed class JSON_RuneSetEffFormatter : 
    IMessagePackFormatter<JSON_RuneSetEff>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001198")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001199")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CCE")]
    [Address(RVA = "0xC04280", Offset = "0xC03080", VA = "0x10C04280")]
    public JSON_RuneSetEffFormatter()
    {
    }

    [Token(Token = "0x6001CCF")]
    [Address(RVA = "0xC03FF0", Offset = "0xC02DF0", VA = "0x10C03FF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneSetEff value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CD0")]
    [Address(RVA = "0xC03C10", Offset = "0xC02A10", VA = "0x10C03C10", Slot = "5")]
    public JSON_RuneSetEff Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneSetEff) null;
    }
  }
}
