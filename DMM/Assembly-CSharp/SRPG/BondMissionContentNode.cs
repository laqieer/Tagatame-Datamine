// Decompiled with JetBrains decompiler
// Type: SRPG.BondMissionContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020C6")]
  public class BondMissionContentNode : ContentNode
  {
    [Token(Token = "0x4008D78")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mParent;
    [Token(Token = "0x4008D79")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private RewardIcon mRewardIconTemplete;
    [Token(Token = "0x4008D7A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ImageArray mContentBase;
    [Token(Token = "0x4008D7B")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mMissionTitle;
    [Token(Token = "0x4008D7C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mBadgeObj;
    [Token(Token = "0x4008D7D")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SRPG_Button mReceiveBtn;
    [Token(Token = "0x4008D7E")]
    [FieldOffset(Offset = "0x48")]
    private List<RewardIcon> mRewardIcons;

    [Token(Token = "0x600889B")]
    [Address(RVA = "0x49C5D0", Offset = "0x49B3D0", VA = "0x1049C5D0")]
    public bool Setup(BondMissionParam param) => new bool();

    [Token(Token = "0x600889C")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public BondMissionContentNode()
    {
    }
  }
}
