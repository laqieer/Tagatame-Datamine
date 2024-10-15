// Decompiled with JetBrains decompiler
// Type: SRPG.BondContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002091")]
  public class BondContentNode : ContentNode
  {
    [Token(Token = "0x4008C67")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image mBackGoundImg;
    [Token(Token = "0x4008C68")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mLevelRoot;
    [Token(Token = "0x4008C69")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mLevelTxt;
    [Token(Token = "0x4008C6A")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mBadgeIcon;
    [Token(Token = "0x4008C6B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mLockBanner;
    [Token(Token = "0x4008C6C")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SRPG_Button mSelectGroupBtn;
    [Token(Token = "0x4008C6D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private SRPG_Button mSelectGroupMemberBtn;
    [Token(Token = "0x4008C6E")]
    [FieldOffset(Offset = "0x4C")]
    private BondGroupParam mBondGroupParam;

    [Token(Token = "0x6008798")]
    [Address(RVA = "0x490250", Offset = "0x48F050", VA = "0x10490250")]
    public bool Setup(BondGroupParam param) => new bool();

    [Token(Token = "0x6008799")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public BondContentNode()
    {
    }
  }
}
