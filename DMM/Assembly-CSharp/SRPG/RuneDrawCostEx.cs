// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawCostEx
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
  [Token(Token = "0x2002983")]
  public class RuneDrawCostEx : MonoBehaviour
  {
    [Token(Token = "0x400C872")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400C873")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mCostParent;
    [Token(Token = "0x400C874")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mCostCoinBase;
    [Token(Token = "0x400C875")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mCostZenyBase;
    [Token(Token = "0x400C876")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mCostItemBase;
    [Token(Token = "0x400C877")]
    [FieldOffset(Offset = "0x20")]
    private RuneDrawCostExModel mModel;
    [Token(Token = "0x400C878")]
    [FieldOffset(Offset = "0x24")]
    private List<RuneDrawCostBlock> mCostList;

    [Token(Token = "0x17001982")]
    public RuneDrawCostExModel Model
    {
      [Token(Token = "0x600BC16"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (RuneDrawCostExModel) null;
      }
    }

    [Token(Token = "0x600BC17")]
    [Address(RVA = "0x83C0F0", Offset = "0x83AEF0", VA = "0x1083C0F0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BC18")]
    [Address(RVA = "0x83BA40", Offset = "0x83A840", VA = "0x1083BA40")]
    public void CreateCostList()
    {
    }

    [Token(Token = "0x600BC19")]
    [Address(RVA = "0x83C1B0", Offset = "0x83AFB0", VA = "0x1083C1B0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC1A")]
    [Address(RVA = "0x83B860", Offset = "0x83A660", VA = "0x1083B860")]
    public void CostRefresh()
    {
    }

    [Token(Token = "0x600BC1B")]
    [Address(RVA = "0x83C2C0", Offset = "0x83B0C0", VA = "0x1083C2C0")]
    public void SetCost(RuneCost runeCost)
    {
    }

    [Token(Token = "0x600BC1C")]
    [Address(RVA = "0x83C290", Offset = "0x83B090", VA = "0x1083C290")]
    public void SetCost(List<RuneCost> runeEnhanceCostList, List<RuneCost> runeEvoCostList)
    {
    }

    [Token(Token = "0x600BC1D")]
    [Address(RVA = "0x83C270", Offset = "0x83B070", VA = "0x1083C270")]
    public void SetChangeButtonIndex(bool isChange)
    {
    }

    [Token(Token = "0x600BC1E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneDrawCostEx()
    {
    }
  }
}
