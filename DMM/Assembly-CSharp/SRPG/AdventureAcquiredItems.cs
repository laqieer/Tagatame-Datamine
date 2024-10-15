// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureAcquiredItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F68")]
  [AddComponentMenu("UI/Adventure/AdventureAcquiredItems")]
  public class AdventureAcquiredItems : MonoBehaviour
  {
    [Token(Token = "0x4008470")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentController CController;
    [Token(Token = "0x4008471")]
    [FieldOffset(Offset = "0x10")]
    [Space(5f)]
    [SerializeField]
    [Description("演出スキップボタン")]
    private Button mSkipButton;
    [Token(Token = "0x4008472")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Description("アイテム獲得アニメ開始トリガー")]
    private string mAnmTurnOnTrigger;
    [Token(Token = "0x4008473")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Description("アイテムごとの再生間隔(秒数)")]
    private float mAnmTriggerInterval;
    [Token(Token = "0x4008474")]
    [FieldOffset(Offset = "0x1C")]
    private AdventureManager mManager;
    [Token(Token = "0x4008475")]
    [FieldOffset(Offset = "0x20")]
    private List<AdventureDrop> mDropList;
    [Token(Token = "0x4008476")]
    [FieldOffset(Offset = "0x24")]
    private List<AdventureAcquiredItemParam> mRewardList;
    [Token(Token = "0x4008477")]
    [FieldOffset(Offset = "0x28")]
    private bool IsSkipped;

    [Token(Token = "0x60080E2")]
    [Address(RVA = "0x418650", Offset = "0x417450", VA = "0x10418650")]
    private void Start()
    {
    }

    [Token(Token = "0x60080E3")]
    [Address(RVA = "0x418500", Offset = "0x417300", VA = "0x10418500")]
    private IEnumerator RewardAnimation(List<AdventureAcquiredItemNode> aain_list)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60080E4")]
    [Address(RVA = "0x418570", Offset = "0x417370", VA = "0x10418570")]
    private void StartSkip()
    {
    }

    [Token(Token = "0x60080E5")]
    [Address(RVA = "0x418460", Offset = "0x417260", VA = "0x10418460")]
    private void FinishSkip()
    {
    }

    [Token(Token = "0x60080E6")]
    [Address(RVA = "0x4184E0", Offset = "0x4172E0", VA = "0x104184E0")]
    private void OnSkip()
    {
    }

    [Token(Token = "0x60080E7")]
    [Address(RVA = "0x418E60", Offset = "0x417C60", VA = "0x10418E60")]
    public AdventureAcquiredItems()
    {
    }
  }
}
