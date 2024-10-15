// Decompiled with JetBrains decompiler
// Type: SRPG.InvalidSkillParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002650")]
  public class InvalidSkillParam : ContentSource.Param
  {
    [Token(Token = "0x400B317")]
    [FieldOffset(Offset = "0x10")]
    public AutoInvalidSkillEditWindow.ETabType TabType;
    [Token(Token = "0x400B318")]
    [FieldOffset(Offset = "0x14")]
    public int Apply_type;
    [Token(Token = "0x400B319")]
    [FieldOffset(Offset = "0x18")]
    public bool IsLocked;
    [Token(Token = "0x400B31A")]
    [FieldOffset(Offset = "0x1C")]
    public EInvalidSkillType ItemType;
    [Token(Token = "0x400B31B")]
    [FieldOffset(Offset = "0x20")]
    public SkillParam Skill;
    [Token(Token = "0x400B31C")]
    [FieldOffset(Offset = "0x24")]
    public JobParam Job;
    [Token(Token = "0x400B31D")]
    [FieldOffset(Offset = "0x28")]
    public EMasterAbilityType AbilityType;
    [Token(Token = "0x400B31E")]
    [FieldOffset(Offset = "0x2C")]
    public string SkillIname;
    [Token(Token = "0x400B31F")]
    [FieldOffset(Offset = "0x30")]
    public ConceptCardData ConceptCard;
    [Token(Token = "0x400B320")]
    [FieldOffset(Offset = "0x34")]
    public ArtifactData Artifact;
    [Token(Token = "0x400B321")]
    [FieldOffset(Offset = "0x38")]
    private InvalidSkillContentNode mNode;

    [Token(Token = "0x600AB12")]
    [Address(RVA = "0x6E49D0", Offset = "0x6E37D0", VA = "0x106E49D0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600AB13")]
    [Address(RVA = "0x6E49A0", Offset = "0x6E37A0", VA = "0x106E49A0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600AB14")]
    [Address(RVA = "0x6E4A90", Offset = "0x6E3890", VA = "0x106E4A90")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600AB15")]
    [Address(RVA = "0x6E4B20", Offset = "0x6E3920", VA = "0x106E4B20")]
    public InvalidSkillParam()
    {
    }
  }
}
