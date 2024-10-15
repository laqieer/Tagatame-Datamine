// Decompiled with JetBrains decompiler
// Type: SRPG.LeaderSkillSelectWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002674")]
  public class LeaderSkillSelectWindow : MonoBehaviour
  {
    [Token(Token = "0x400B3AD")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B3AE")]
    [FieldOffset(Offset = "0x10")]
    private LeaderSkillSelectWindowModel mModel;

    [Token(Token = "0x600ABA5")]
    [Address(RVA = "0x6EBBE0", Offset = "0x6EA9E0", VA = "0x106EBBE0")]
    public void Initialize(UnitData unitData)
    {
    }

    [Token(Token = "0x600ABA6")]
    [Address(RVA = "0x6EBD10", Offset = "0x6EAB10", VA = "0x106EBD10")]
    public void Setup()
    {
    }

    [Token(Token = "0x600ABA7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeaderSkillSelectWindow()
    {
    }
  }
}
