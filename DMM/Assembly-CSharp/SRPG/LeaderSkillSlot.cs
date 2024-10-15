// Decompiled with JetBrains decompiler
// Type: SRPG.LeaderSkillSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002675")]
  public class LeaderSkillSlot : MonoBehaviour
  {
    [Token(Token = "0x400B3AF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B3B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button mSkillChangeButton;
    [Token(Token = "0x400B3B1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private LeaderSkillSelectWindow mLeaderSkillSelectWindow;
    [Token(Token = "0x400B3B2")]
    [FieldOffset(Offset = "0x18")]
    private LeaderSkillSlotModel mModel;

    [Token(Token = "0x600ABA8")]
    [Address(RVA = "0x6EBD90", Offset = "0x6EAB90", VA = "0x106EBD90")]
    public void Initialize(UnitData unitData, bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600ABA9")]
    [Address(RVA = "0x6EBF30", Offset = "0x6EAD30", VA = "0x106EBF30")]
    public void Setup(UnitData unitData, bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600ABAA")]
    [Address(RVA = "0x6EBEB0", Offset = "0x6EACB0", VA = "0x106EBEB0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600ABAB")]
    [Address(RVA = "0x6EBE10", Offset = "0x6EAC10", VA = "0x106EBE10")]
    public void Refresh(UnitData unitData)
    {
    }

    [Token(Token = "0x600ABAC")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeaderSkillSlot()
    {
    }
  }
}
