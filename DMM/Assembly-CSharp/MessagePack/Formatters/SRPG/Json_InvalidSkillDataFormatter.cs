// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_InvalidSkillDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005A1")]
  public sealed class Json_InvalidSkillDataFormatter : 
    IMessagePackFormatter<Json_InvalidSkillData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FDA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FDB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A31")]
    [Address(RVA = "0x79B7D0", Offset = "0x79A5D0", VA = "0x1079B7D0")]
    public Json_InvalidSkillDataFormatter()
    {
    }

    [Token(Token = "0x6001A32")]
    [Address(RVA = "0x79B660", Offset = "0x79A460", VA = "0x1079B660", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_InvalidSkillData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A33")]
    [Address(RVA = "0x79B2F0", Offset = "0x79A0F0", VA = "0x1079B2F0", Slot = "5")]
    public Json_InvalidSkillData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_InvalidSkillData) null;
    }
  }
}
