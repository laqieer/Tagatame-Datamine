// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LearningSkillFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200078C")]
  public sealed class LearningSkillFormatter : 
    IMessagePackFormatter<LearningSkill>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013B0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013B1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FF2")]
    [Address(RVA = "0xCDF6A0", Offset = "0xCDE4A0", VA = "0x10CDF6A0")]
    public LearningSkillFormatter()
    {
    }

    [Token(Token = "0x6001FF3")]
    [Address(RVA = "0xCDF570", Offset = "0xCDE370", VA = "0x10CDF570", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LearningSkill value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FF4")]
    [Address(RVA = "0xCDF260", Offset = "0xCDE060", VA = "0x10CDF260", Slot = "5")]
    public LearningSkill Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LearningSkill) null;
    }
  }
}
