// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillDistanceDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007BA")]
  public sealed class SkillDistanceDataParamFormatter : 
    IMessagePackFormatter<SkillDistanceDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001404")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001405")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600207C")]
    [Address(RVA = "0xD0B250", Offset = "0xD0A050", VA = "0x10D0B250")]
    public SkillDistanceDataParamFormatter()
    {
    }

    [Token(Token = "0x600207D")]
    [Address(RVA = "0xD0ADB0", Offset = "0xD09BB0", VA = "0x10D0ADB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillDistanceDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600207E")]
    [Address(RVA = "0xD0A9F0", Offset = "0xD097F0", VA = "0x10D0A9F0", Slot = "5")]
    public SkillDistanceDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillDistanceDataParam) null;
    }
  }
}
