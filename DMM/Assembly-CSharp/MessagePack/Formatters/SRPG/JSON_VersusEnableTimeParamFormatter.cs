// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusEnableTimeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000853")]
  public sealed class JSON_VersusEnableTimeParamFormatter : 
    IMessagePackFormatter<JSON_VersusEnableTimeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001536")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001537")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002247")]
    [Address(RVA = "0xD90CF0", Offset = "0xD8FAF0", VA = "0x10D90CF0")]
    public JSON_VersusEnableTimeParamFormatter()
    {
    }

    [Token(Token = "0x6002248")]
    [Address(RVA = "0xD908C0", Offset = "0xD8F6C0", VA = "0x10D908C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusEnableTimeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002249")]
    [Address(RVA = "0xD90350", Offset = "0xD8F150", VA = "0x10D90350", Slot = "5")]
    public JSON_VersusEnableTimeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusEnableTimeParam) null;
    }
  }
}
