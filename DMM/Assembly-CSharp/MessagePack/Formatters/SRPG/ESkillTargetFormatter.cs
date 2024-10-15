// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ESkillTargetFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000544")]
  public sealed class ESkillTargetFormatter : 
    IMessagePackFormatter<ESkillTarget>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600191A")]
    [Address(RVA = "0x69BCC0", Offset = "0x69AAC0", VA = "0x1069BCC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ESkillTarget value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600191B")]
    [Address(RVA = "0x69BC70", Offset = "0x69AA70", VA = "0x1069BC70", Slot = "5")]
    public ESkillTarget Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ESkillTarget();
    }

    [Token(Token = "0x600191C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ESkillTargetFormatter()
    {
    }
  }
}
