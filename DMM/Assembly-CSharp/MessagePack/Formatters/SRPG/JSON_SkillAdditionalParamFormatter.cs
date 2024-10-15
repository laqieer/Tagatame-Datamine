// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillAdditionalParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006A0")]
  public sealed class JSON_SkillAdditionalParamFormatter : 
    IMessagePackFormatter<JSON_SkillAdditionalParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011D8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011D9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D2E")]
    [Address(RVA = "0xC04B20", Offset = "0xC03920", VA = "0x10C04B20")]
    public JSON_SkillAdditionalParamFormatter()
    {
    }

    [Token(Token = "0x6001D2F")]
    [Address(RVA = "0xC04920", Offset = "0xC03720", VA = "0x10C04920", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillAdditionalParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D30")]
    [Address(RVA = "0xC04550", Offset = "0xC03350", VA = "0x10C04550", Slot = "5")]
    public JSON_SkillAdditionalParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillAdditionalParam) null;
    }
  }
}
