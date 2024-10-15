// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ESkillConditionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000540")]
  public sealed class ESkillConditionFormatter : 
    IMessagePackFormatter<ESkillCondition>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600190E")]
    [Address(RVA = "0x69BB80", Offset = "0x69A980", VA = "0x1069BB80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ESkillCondition value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600190F")]
    [Address(RVA = "0x69BB30", Offset = "0x69A930", VA = "0x1069BB30", Slot = "5")]
    public ESkillCondition Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ESkillCondition();
    }

    [Token(Token = "0x6001910")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ESkillConditionFormatter()
    {
    }
  }
}
