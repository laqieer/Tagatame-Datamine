// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_InspSkillParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200064B")]
  public sealed class JSON_InspSkillParamFormatter : 
    IMessagePackFormatter<JSON_InspSkillParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400112E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400112F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C2F")]
    [Address(RVA = "0xBDB9B0", Offset = "0xBDA7B0", VA = "0x10BDB9B0")]
    public JSON_InspSkillParamFormatter()
    {
    }

    [Token(Token = "0x6001C30")]
    [Address(RVA = "0xBDB620", Offset = "0xBDA420", VA = "0x10BDB620", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_InspSkillParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C31")]
    [Address(RVA = "0xBDB150", Offset = "0xBD9F50", VA = "0x10BDB150", Slot = "5")]
    public JSON_InspSkillParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_InspSkillParam) null;
    }
  }
}
