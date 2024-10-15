// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ESkillTimingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200053F")]
  public sealed class ESkillTimingFormatter : 
    IMessagePackFormatter<ESkillTiming>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600190B")]
    [Address(RVA = "0x69BD60", Offset = "0x69AB60", VA = "0x1069BD60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ESkillTiming value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600190C")]
    [Address(RVA = "0x69BD10", Offset = "0x69AB10", VA = "0x1069BD10", Slot = "5")]
    public ESkillTiming Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ESkillTiming();
    }

    [Token(Token = "0x600190D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ESkillTimingFormatter()
    {
    }
  }
}
