// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideBoardBonusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029FD")]
  public class RunePrideBoardBonusView : MonoBehaviour
  {
    [Token(Token = "0x400CC03")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400CC04")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button BonusButton;
    [Token(Token = "0x400CC05")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RunePrideParameterListView ListView;
    [Token(Token = "0x400CC06")]
    [FieldOffset(Offset = "0x18")]
    private RunePrideBoardBonusModel mModel;
    [Token(Token = "0x400CC07")]
    [FieldOffset(Offset = "0x1C")]
    private RunePrideBonusParam mParam;
    [Token(Token = "0x400CC08")]
    [FieldOffset(Offset = "0x20")]
    private UnitData mUnitData;
    [Token(Token = "0x400CC09")]
    [FieldOffset(Offset = "0x24")]
    private int mBonusNum;
    [Token(Token = "0x400CC0A")]
    [FieldOffset(Offset = "0x28")]
    private int mAddBonusNum;

    [Token(Token = "0x600BF5E")]
    [Address(RVA = "0x87D080", Offset = "0x87BE80", VA = "0x1087D080")]
    public void SetUp(RunePrideBonusParam _param, int _bonus_num, Action _action)
    {
    }

    [Token(Token = "0x600BF5F")]
    [Address(RVA = "0x87D050", Offset = "0x87BE50", VA = "0x1087D050")]
    public void Refresh(int _bonus_num)
    {
    }

    [Token(Token = "0x600BF60")]
    [Address(RVA = "0x87CF50", Offset = "0x87BD50", VA = "0x1087CF50")]
    public void ClearBonusNum()
    {
    }

    [Token(Token = "0x600BF61")]
    [Address(RVA = "0x87CEC0", Offset = "0x87BCC0", VA = "0x1087CEC0")]
    public void AddBonusNum(int _add_bonus_num)
    {
    }

    [Token(Token = "0x600BF62")]
    [Address(RVA = "0x87D580", Offset = "0x87C380", VA = "0x1087D580")]
    public void SubBonusNum(int _sub_bonus_num)
    {
    }

    [Token(Token = "0x600BF63")]
    [Address(RVA = "0x87CFD0", Offset = "0x87BDD0", VA = "0x1087CFD0")]
    private void Draw()
    {
    }

    [Token(Token = "0x600BF64")]
    [Address(RVA = "0x87CEA0", Offset = "0x87BCA0", VA = "0x1087CEA0")]
    public void ActiveSelect(bool _is_active)
    {
    }

    [Token(Token = "0x600BF65")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RunePrideBoardBonusView()
    {
    }
  }
}
