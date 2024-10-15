// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalReplaceFilterCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006DE")]
  public sealed class JSON_CrystalReplaceFilterCondParamFormatter : 
    IMessagePackFormatter<JSON_CrystalReplaceFilterCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001254")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001255")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DE8")]
    [Address(RVA = "0xC25AB0", Offset = "0xC248B0", VA = "0x10C25AB0")]
    public JSON_CrystalReplaceFilterCondParamFormatter()
    {
    }

    [Token(Token = "0x6001DE9")]
    [Address(RVA = "0xC25810", Offset = "0xC24610", VA = "0x10C25810", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalReplaceFilterCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DEA")]
    [Address(RVA = "0xC253A0", Offset = "0xC241A0", VA = "0x10C253A0", Slot = "5")]
    public JSON_CrystalReplaceFilterCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalReplaceFilterCondParam) null;
    }
  }
}
