// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalReplaceSetBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200228D")]
  public class CrystalReplaceSetBonus : MonoBehaviour
  {
    [Token(Token = "0x4009974")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mParent;
    [Token(Token = "0x4009975")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitListTemplete;
    [Token(Token = "0x4009976")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ScrollRect mScrollRect;
    [Token(Token = "0x4009977")]
    [FieldOffset(Offset = "0x18")]
    private List<ExhibitList> SetBonusList;

    [Token(Token = "0x60093E1")]
    [Address(RVA = "0x56DAB0", Offset = "0x56C8B0", VA = "0x1056DAB0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60093E2")]
    [Address(RVA = "0x56DB00", Offset = "0x56C900", VA = "0x1056DB00")]
    public void Setup(List<CrystalSetBonusWindowModel> set_bonus_list)
    {
    }

    [Token(Token = "0x60093E3")]
    [Address(RVA = "0x56DE50", Offset = "0x56CC50", VA = "0x1056DE50")]
    public CrystalReplaceSetBonus()
    {
    }
  }
}
