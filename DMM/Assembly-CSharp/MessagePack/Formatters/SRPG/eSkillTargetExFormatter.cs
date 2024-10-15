// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eSkillTargetExFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000551")]
  public sealed class eSkillTargetExFormatter : 
    IMessagePackFormatter<eSkillTargetEx>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001941")]
    [Address(RVA = "0x6B1840", Offset = "0x6B0640", VA = "0x106B1840", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eSkillTargetEx value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001942")]
    [Address(RVA = "0x6B17F0", Offset = "0x6B05F0", VA = "0x106B17F0", Slot = "5")]
    public eSkillTargetEx Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eSkillTargetEx();
    }

    [Token(Token = "0x6001943")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eSkillTargetExFormatter()
    {
    }
  }
}
