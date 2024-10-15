// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eTeleportSkillPosFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000552")]
  public sealed class eTeleportSkillPosFormatter : 
    IMessagePackFormatter<eTeleportSkillPos>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001944")]
    [Address(RVA = "0x6B18E0", Offset = "0x6B06E0", VA = "0x106B18E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eTeleportSkillPos value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001945")]
    [Address(RVA = "0x6B1890", Offset = "0x6B0690", VA = "0x106B1890", Slot = "5")]
    public eTeleportSkillPos Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eTeleportSkillPos();
    }

    [Token(Token = "0x6001946")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eTeleportSkillPosFormatter()
    {
    }
  }
}
