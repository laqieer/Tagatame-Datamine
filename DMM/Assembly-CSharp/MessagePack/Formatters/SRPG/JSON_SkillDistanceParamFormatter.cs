// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillDistanceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006FE")]
  public sealed class JSON_SkillDistanceParamFormatter : 
    IMessagePackFormatter<JSON_SkillDistanceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001294")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001295")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E48")]
    [Address(RVA = "0xC37C00", Offset = "0xC36A00", VA = "0x10C37C00")]
    public JSON_SkillDistanceParamFormatter()
    {
    }

    [Token(Token = "0x6001E49")]
    [Address(RVA = "0xC37940", Offset = "0xC36740", VA = "0x10C37940", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillDistanceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E4A")]
    [Address(RVA = "0xC37520", Offset = "0xC36320", VA = "0x10C37520", Slot = "5")]
    public JSON_SkillDistanceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillDistanceParam) null;
    }
  }
}
