// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillDistanceDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006FD")]
  public sealed class JSON_SkillDistanceDataParamFormatter : 
    IMessagePackFormatter<JSON_SkillDistanceDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001292")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001293")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E45")]
    [Address(RVA = "0xC371F0", Offset = "0xC35FF0", VA = "0x10C371F0")]
    public JSON_SkillDistanceDataParamFormatter()
    {
    }

    [Token(Token = "0x6001E46")]
    [Address(RVA = "0xC36FA0", Offset = "0xC35DA0", VA = "0x10C36FA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillDistanceDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E47")]
    [Address(RVA = "0xC36B70", Offset = "0xC35970", VA = "0x10C36B70", Slot = "5")]
    public JSON_SkillDistanceDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillDistanceDataParam) null;
    }
  }
}
