// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillAntiShieldParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006A1")]
  public sealed class JSON_SkillAntiShieldParamFormatter : 
    IMessagePackFormatter<JSON_SkillAntiShieldParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011DA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011DB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D31")]
    [Address(RVA = "0xC05470", Offset = "0xC04270", VA = "0x10C05470")]
    public JSON_SkillAntiShieldParamFormatter()
    {
    }

    [Token(Token = "0x6001D32")]
    [Address(RVA = "0xC05220", Offset = "0xC04020", VA = "0x10C05220", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillAntiShieldParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D33")]
    [Address(RVA = "0xC04DF0", Offset = "0xC03BF0", VA = "0x10C04DF0", Slot = "5")]
    public JSON_SkillAntiShieldParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillAntiShieldParam) null;
    }
  }
}
