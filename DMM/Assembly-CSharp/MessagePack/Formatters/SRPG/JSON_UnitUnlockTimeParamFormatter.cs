// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitUnlockTimeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000606")]
  public sealed class JSON_UnitUnlockTimeParamFormatter : 
    IMessagePackFormatter<JSON_UnitUnlockTimeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010A4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010A5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B60")]
    [Address(RVA = "0xBB1700", Offset = "0xBB0500", VA = "0x10BB1700")]
    public JSON_UnitUnlockTimeParamFormatter()
    {
    }

    [Token(Token = "0x6001B61")]
    [Address(RVA = "0xBB1500", Offset = "0xBB0300", VA = "0x10BB1500", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitUnlockTimeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B62")]
    [Address(RVA = "0xBB1130", Offset = "0xBAFF30", VA = "0x10BB1130", Slot = "5")]
    public JSON_UnitUnlockTimeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitUnlockTimeParam) null;
    }
  }
}
