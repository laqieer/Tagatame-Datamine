// Decompiled with JetBrains decompiler
// Type: SRPG.SkillViewList
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
  [Token(Token = "0x2002ABA")]
  [AddComponentMenu("UI/SkillViewList")]
  public class SkillViewList : MonoBehaviour
  {
    [Token(Token = "0x400D071")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mBaseExhibitList;
    [Token(Token = "0x400D072")]
    [FieldOffset(Offset = "0x10")]
    private SkillModel mSkillModel;

    [Token(Token = "0x600C321")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C322")]
    [Address(RVA = "0x8B9230", Offset = "0x8B8030", VA = "0x108B9230")]
    public void Setup(SkillParam _skillParam)
    {
    }

    [Token(Token = "0x600C323")]
    [Address(RVA = "0x8B9340", Offset = "0x8B8140", VA = "0x108B9340")]
    public SkillViewList()
    {
    }
  }
}
