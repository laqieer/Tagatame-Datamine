// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawCost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002981")]
  [AddComponentMenu("UI/Rune/RuneDrawCost")]
  public class RuneDrawCost : MonoBehaviour
  {
    [Token(Token = "0x400C85F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mZenyParent;
    [Token(Token = "0x400C860")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mZeny;
    [Token(Token = "0x400C861")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mZenyInfinity;
    [Token(Token = "0x400C862")]
    [FieldOffset(Offset = "0x18")]
    [Space(5f)]
    [SerializeField]
    private GameObject mMaterialParent;
    [Token(Token = "0x400C863")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RawImage mMaterialImg;
    [Token(Token = "0x400C864")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mMaterialNum;
    [Token(Token = "0x400C865")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mMaterialNumInfinity;
    [Token(Token = "0x400C866")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Space(5f)]
    private GameObject mCoinParent;
    [Token(Token = "0x400C867")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text mCoin;
    [Token(Token = "0x400C868")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mCoinInfinity;
    [Token(Token = "0x400C869")]
    [FieldOffset(Offset = "0x34")]
    [Space(5f)]
    [SerializeField]
    private Text mName;
    [Token(Token = "0x400C86A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mAmount;
    [Token(Token = "0x400C86B")]
    [FieldOffset(Offset = "0x3C")]
    private RuneCost mRuneCost;
    [Token(Token = "0x400C86C")]
    [FieldOffset(Offset = "0x40")]
    private int mMaxViewNum;
    [Token(Token = "0x400C86D")]
    [FieldOffset(Offset = "0x44")]
    private int mUseCount;

    [Token(Token = "0x600BC0E")]
    [Address(RVA = "0x83C360", Offset = "0x83B160", VA = "0x1083C360")]
    public bool IsEnoughCost() => new bool();

    [Token(Token = "0x600BC0F")]
    [Address(RVA = "0x83CCB0", Offset = "0x83BAB0", VA = "0x1083CCB0")]
    public void SetDrawParam(RuneCost rune_cost, int max_view_num = 0, int use_count = 1)
    {
    }

    [Token(Token = "0x600BC10")]
    [Address(RVA = "0x83C490", Offset = "0x83B290", VA = "0x1083C490")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC11")]
    [Address(RVA = "0x83CDB0", Offset = "0x83BBB0", VA = "0x1083CDB0")]
    public RuneDrawCost()
    {
    }
  }
}
