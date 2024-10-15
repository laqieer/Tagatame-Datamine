// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eInspSkillTriggerTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200056C")]
  public sealed class eInspSkillTriggerTypeFormatter : 
    IMessagePackFormatter<eInspSkillTriggerType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001992")]
    [Address(RVA = "0x6B1520", Offset = "0x6B0320", VA = "0x106B1520", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eInspSkillTriggerType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001993")]
    [Address(RVA = "0x6B14D0", Offset = "0x6B02D0", VA = "0x106B14D0", Slot = "5")]
    public eInspSkillTriggerType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eInspSkillTriggerType();
    }

    [Token(Token = "0x6001994")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eInspSkillTriggerTypeFormatter()
    {
    }
  }
}
