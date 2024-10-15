// Decompiled with JetBrains decompiler
// Type: SRPG.SkillMotion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E47")]
  public class SkillMotion
  {
    [Token(Token = "0x4007B49")]
    [FieldOffset(Offset = "0x8")]
    public string MotionId;
    [Token(Token = "0x4007B4A")]
    [FieldOffset(Offset = "0xC")]
    public string EffectId;
    [Token(Token = "0x4007B4B")]
    [FieldOffset(Offset = "0x10")]
    public bool IsBattleScene;

    [Token(Token = "0x6007C41")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillMotion()
    {
    }

    [Token(Token = "0x6007C42")]
    [Address(RVA = "0x3E8710", Offset = "0x3E7510", VA = "0x103E8710")]
    public SkillMotion(SkillMotionDataParam smdp)
    {
    }
  }
}
