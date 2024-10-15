// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007AA")]
  public sealed class SkillDataFormatter : IMessagePackFormatter<SkillData>, IMessagePackFormatter
  {
    [Token(Token = "0x40013E8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013E9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600204C")]
    [Address(RVA = "0xCFA070", Offset = "0xCF8E70", VA = "0x10CFA070")]
    public SkillDataFormatter()
    {
    }

    [Token(Token = "0x600204D")]
    [Address(RVA = "0xCF72C0", Offset = "0xCF60C0", VA = "0x10CF72C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600204E")]
    [Address(RVA = "0xCF6150", Offset = "0xCF4F50", VA = "0x10CF6150", Slot = "5")]
    public SkillData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillData) null;
    }
  }
}
