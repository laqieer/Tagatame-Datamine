// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_InvalidSkillApplyTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005A2")]
  public sealed class Json_InvalidSkillApplyTypeFormatter : 
    IMessagePackFormatter<Json_InvalidSkillApplyType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FDC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FDD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A34")]
    [Address(RVA = "0x79B170", Offset = "0x799F70", VA = "0x1079B170")]
    public Json_InvalidSkillApplyTypeFormatter()
    {
    }

    [Token(Token = "0x6001A35")]
    [Address(RVA = "0x79AFD0", Offset = "0x799DD0", VA = "0x1079AFD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_InvalidSkillApplyType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A36")]
    [Address(RVA = "0x79ACC0", Offset = "0x799AC0", VA = "0x1079ACC0", Slot = "5")]
    public Json_InvalidSkillApplyType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_InvalidSkillApplyType) null;
    }
  }
}
