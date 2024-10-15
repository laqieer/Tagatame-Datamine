// Decompiled with JetBrains decompiler
// Type: SRPG.QuestCampaignInspSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C31")]
  public class QuestCampaignInspSkill
  {
    [Token(Token = "0x4006D63")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006D64")]
    [FieldOffset(Offset = "0xC")]
    private string mInspirationSkillIname;
    [Token(Token = "0x4006D65")]
    [FieldOffset(Offset = "0x10")]
    private int mRate;

    [Token(Token = "0x17000E95")]
    public string Iname
    {
      [Token(Token = "0x60073F7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E96")]
    public string InspirationSkillIname
    {
      [Token(Token = "0x60073F8"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E97")]
    public int Rate
    {
      [Token(Token = "0x60073F9"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60073FA")]
    [Address(RVA = "0x381480", Offset = "0x380280", VA = "0x10381480")]
    public bool Deserialize(JSON_QuestCampaignInspSkill json) => new bool();

    [Token(Token = "0x60073FB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public QuestCampaignInspSkill()
    {
    }
  }
}
