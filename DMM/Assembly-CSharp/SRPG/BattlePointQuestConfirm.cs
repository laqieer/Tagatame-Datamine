// Decompiled with JetBrains decompiler
// Type: SRPG.BattlePointQuestConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027FA")]
  public class BattlePointQuestConfirm : MonoBehaviour
  {
    [Token(Token = "0x400BE49")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ListParent;
    [Token(Token = "0x400BE4A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PointQuestMissionItem BaseItem;
    [Token(Token = "0x400BE4B")]
    [FieldOffset(Offset = "0x14")]
    private BattlePointData mData;
    [Token(Token = "0x400BE4C")]
    [FieldOffset(Offset = "0x18")]
    private List<PointQuestBonusObjective> mList;
    [Token(Token = "0x400BE4D")]
    [FieldOffset(Offset = "0x1C")]
    private bool isBattle;

    [Token(Token = "0x600B47B")]
    [Address(RVA = "0x7A5440", Offset = "0x7A4240", VA = "0x107A5440")]
    private void Start()
    {
    }

    [Token(Token = "0x600B47C")]
    [Address(RVA = "0x7A51D0", Offset = "0x7A3FD0", VA = "0x107A51D0")]
    private void CreateList()
    {
    }

    [Token(Token = "0x600B47D")]
    [Address(RVA = "0x7A5650", Offset = "0x7A4450", VA = "0x107A5650")]
    public BattlePointQuestConfirm()
    {
    }
  }
}
