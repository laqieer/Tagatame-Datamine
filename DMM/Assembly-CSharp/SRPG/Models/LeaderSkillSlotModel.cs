// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeaderSkillSlotModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003350")]
  public class LeaderSkillSlotModel
  {
    [Token(Token = "0x400F223")]
    [FieldOffset(Offset = "0x8")]
    private readonly string UNIT_LEADERSKILL_NOTHAVE_NAME;
    [Token(Token = "0x400F224")]
    [FieldOffset(Offset = "0xC")]
    private readonly string UNIT_LEADERSKILL_NOTHAVE_MESSAGE;
    [Token(Token = "0x400F225")]
    [FieldOffset(Offset = "0x10")]
    private readonly string LEADERSKILL_HIDE_NAME;
    [Token(Token = "0x400F226")]
    [FieldOffset(Offset = "0x14")]
    private readonly string LEADERSKILL_HIDE_MESSAGE;
    [Token(Token = "0x400F227")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsEdit;
    [Token(Token = "0x400F228")]
    [FieldOffset(Offset = "0x19")]
    private bool mIsHideMode;
    [Token(Token = "0x400F229")]
    [FieldOffset(Offset = "0x1C")]
    private string mLeaderSkill;
    [Token(Token = "0x400F22A")]
    [FieldOffset(Offset = "0x20")]
    private string mLeaderSkillExplanation;
    [Token(Token = "0x400F22B")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsSelectWindow;
    [Token(Token = "0x400F22C")]
    [FieldOffset(Offset = "0x25")]
    private bool mIsSkillChangeButton;
    [Token(Token = "0x400F22D")]
    [FieldOffset(Offset = "0x28")]
    private int mLeaderSkillBGImageIndex;

    [Token(Token = "0x17001E73")]
    public bool IsEdit
    {
      [Token(Token = "0x600E30C"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E74")]
    public bool IsHideMode
    {
      [Token(Token = "0x600E30D"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E75")]
    public string LeaderSkill
    {
      [Token(Token = "0x600E30E"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E76")]
    public string LeaderSkillExplanation
    {
      [Token(Token = "0x600E30F"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E77")]
    public bool IsSelectWindow
    {
      [Token(Token = "0x600E310"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E78")]
    public bool IsSkillChangeButton
    {
      [Token(Token = "0x600E311"), Address(RVA = "0x628F10", Offset = "0x627D10", VA = "0x10628F10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E79")]
    public int LeaderSkillBGImageIndex
    {
      [Token(Token = "0x600E312"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E313")]
    [Address(RVA = "0xAB2640", Offset = "0xAB1440", VA = "0x10AB2640")]
    public LeaderSkillSlotModel(bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600E314")]
    [Address(RVA = "0xAB2310", Offset = "0xAB1110", VA = "0x10AB2310")]
    public void Initialize(UnitData unitData)
    {
    }

    [Token(Token = "0x600E315")]
    [Address(RVA = "0xAB2520", Offset = "0xAB1320", VA = "0x10AB2520")]
    public void SetupData(UnitData unitData)
    {
    }

    [Token(Token = "0x600E316")]
    [Address(RVA = "0xAB24A0", Offset = "0xAB12A0", VA = "0x10AB24A0")]
    private void SetHideMode()
    {
    }
  }
}
