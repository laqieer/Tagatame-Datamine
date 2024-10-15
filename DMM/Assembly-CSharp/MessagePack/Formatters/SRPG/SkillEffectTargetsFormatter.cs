// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillEffectTargetsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000579")]
  public sealed class SkillEffectTargetsFormatter : 
    IMessagePackFormatter<SkillEffectTargets>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019B9")]
    [Address(RVA = "0x6AAB30", Offset = "0x6A9930", VA = "0x106AAB30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillEffectTargets value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019BA")]
    [Address(RVA = "0x6AAAE0", Offset = "0x6A98E0", VA = "0x106AAAE0", Slot = "5")]
    public SkillEffectTargets Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new SkillEffectTargets();
    }

    [Token(Token = "0x60019BB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillEffectTargetsFormatter()
    {
    }
  }
}
