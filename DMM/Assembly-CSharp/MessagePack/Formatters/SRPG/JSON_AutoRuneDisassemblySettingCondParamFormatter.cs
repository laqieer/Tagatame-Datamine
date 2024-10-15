// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AutoRuneDisassemblySettingCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000685")]
  public sealed class JSON_AutoRuneDisassemblySettingCondParamFormatter : 
    IMessagePackFormatter<JSON_AutoRuneDisassemblySettingCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011A2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011A3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CDD")]
    [Address(RVA = "0xBF6CF0", Offset = "0xBF5AF0", VA = "0x10BF6CF0")]
    public JSON_AutoRuneDisassemblySettingCondParamFormatter()
    {
    }

    [Token(Token = "0x6001CDE")]
    [Address(RVA = "0xBF6B30", Offset = "0xBF5930", VA = "0x10BF6B30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AutoRuneDisassemblySettingCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CDF")]
    [Address(RVA = "0xBF67A0", Offset = "0xBF55A0", VA = "0x10BF67A0", Slot = "5")]
    public JSON_AutoRuneDisassemblySettingCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AutoRuneDisassemblySettingCondParam) null;
    }
  }
}
