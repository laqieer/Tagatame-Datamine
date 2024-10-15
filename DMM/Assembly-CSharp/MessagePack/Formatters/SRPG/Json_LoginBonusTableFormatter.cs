// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_LoginBonusTableFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200086D")]
  public sealed class Json_LoginBonusTableFormatter : 
    IMessagePackFormatter<Json_LoginBonusTable>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400156A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400156B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002295")]
    [Address(RVA = "0xD94970", Offset = "0xD93770", VA = "0x10D94970")]
    public Json_LoginBonusTableFormatter()
    {
    }

    [Token(Token = "0x6002296")]
    [Address(RVA = "0xD943D0", Offset = "0xD931D0", VA = "0x10D943D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_LoginBonusTable value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002297")]
    [Address(RVA = "0xD93DC0", Offset = "0xD92BC0", VA = "0x10D93DC0", Slot = "5")]
    public Json_LoginBonusTable Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_LoginBonusTable) null;
    }
  }
}
