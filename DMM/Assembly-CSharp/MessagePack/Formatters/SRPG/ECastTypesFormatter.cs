// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ECastTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000543")]
  public sealed class ECastTypesFormatter : IMessagePackFormatter<ECastTypes>, IMessagePackFormatter
  {
    [Token(Token = "0x6001917")]
    [Address(RVA = "0x69B4A0", Offset = "0x69A2A0", VA = "0x1069B4A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ECastTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001918")]
    [Address(RVA = "0x69B450", Offset = "0x69A250", VA = "0x1069B450", Slot = "5")]
    public ECastTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ECastTypes();
    }

    [Token(Token = "0x6001919")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ECastTypesFormatter()
    {
    }
  }
}
