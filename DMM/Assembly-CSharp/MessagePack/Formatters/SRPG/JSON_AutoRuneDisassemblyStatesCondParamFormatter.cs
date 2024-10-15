// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AutoRuneDisassemblyStatesCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000687")]
  public sealed class JSON_AutoRuneDisassemblyStatesCondParamFormatter : 
    IMessagePackFormatter<JSON_AutoRuneDisassemblyStatesCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011A6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011A7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CE3")]
    [Address(RVA = "0xBF7A30", Offset = "0xBF6830", VA = "0x10BF7A30")]
    public JSON_AutoRuneDisassemblyStatesCondParamFormatter()
    {
    }

    [Token(Token = "0x6001CE4")]
    [Address(RVA = "0xBF7900", Offset = "0xBF6700", VA = "0x10BF7900", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AutoRuneDisassemblyStatesCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CE5")]
    [Address(RVA = "0xBF75F0", Offset = "0xBF63F0", VA = "0x10BF75F0", Slot = "5")]
    public JSON_AutoRuneDisassemblyStatesCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AutoRuneDisassemblyStatesCondParam) null;
    }
  }
}
