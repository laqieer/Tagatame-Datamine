// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eHealTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200053C")]
  public sealed class eHealTypeFormatter : 
    IMessagePackFormatter<SkillCriticalHealParam.eHealType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001902")]
    [Address(RVA = "0x6B1480", Offset = "0x6B0280", VA = "0x106B1480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillCriticalHealParam.eHealType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001903")]
    [Address(RVA = "0x6B1430", Offset = "0x6B0230", VA = "0x106B1430", Slot = "5")]
    public SkillCriticalHealParam.eHealType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new SkillCriticalHealParam.eHealType();
    }

    [Token(Token = "0x6001904")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eHealTypeFormatter()
    {
    }
  }
}
