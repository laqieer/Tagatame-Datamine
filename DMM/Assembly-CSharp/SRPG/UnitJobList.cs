// Decompiled with JetBrains decompiler
// Type: SRPG.UnitJobList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C4F")]
  public class UnitJobList : PulldownItem
  {
    [Token(Token = "0x400DB54")]
    private const int CurrentJobIndex = -1;
    [Token(Token = "0x400DB55")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400DB56")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform mParentObj;
    [Token(Token = "0x400DB57")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private UnitJobList mTempObj;
    [Token(Token = "0x400DB58")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UnitJobList mParentUnitJobList;
    [Token(Token = "0x400DB59")]
    [FieldOffset(Offset = "0x34")]
    private UnitJobListModel mModel;
    [Token(Token = "0x400DB5A")]
    [FieldOffset(Offset = "0x38")]
    private List<UnitJobList> mPullDownList;

    [Token(Token = "0x600CD3F")]
    [Address(RVA = "0x980500", Offset = "0x97F300", VA = "0x10980500")]
    public void Initialize(UnitData unitData, bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600CD40")]
    [Address(RVA = "0x980520", Offset = "0x97F320", VA = "0x10980520")]
    public void Initialize(UnitData unitData, int index, bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600CD41")]
    [Address(RVA = "0x980660", Offset = "0x97F460", VA = "0x10980660")]
    public void SetupModel(UnitData unitData, int index, bool isEdit = true, bool isHode = false)
    {
    }

    [Token(Token = "0x600CD42")]
    [Address(RVA = "0x9805E0", Offset = "0x97F3E0", VA = "0x109805E0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600CD43")]
    [Address(RVA = "0x9805B0", Offset = "0x97F3B0", VA = "0x109805B0")]
    public void Refresh(UnitData unitData)
    {
    }

    [Token(Token = "0x600CD44")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitJobList()
    {
    }
  }
}
