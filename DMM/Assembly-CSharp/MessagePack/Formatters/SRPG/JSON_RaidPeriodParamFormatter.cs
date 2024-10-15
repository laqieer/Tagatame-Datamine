// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidPeriodParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200061D")]
  public sealed class JSON_RaidPeriodParamFormatter : 
    IMessagePackFormatter<JSON_RaidPeriodParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010D2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010D3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BA5")]
    [Address(RVA = "0xBC4760", Offset = "0xBC3560", VA = "0x10BC4760")]
    public JSON_RaidPeriodParamFormatter()
    {
    }

    [Token(Token = "0x6001BA6")]
    [Address(RVA = "0xBC4360", Offset = "0xBC3160", VA = "0x10BC4360", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidPeriodParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BA7")]
    [Address(RVA = "0xBC3D90", Offset = "0xBC2B90", VA = "0x10BC3D90", Slot = "5")]
    public JSON_RaidPeriodParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidPeriodParam) null;
    }
  }
}
