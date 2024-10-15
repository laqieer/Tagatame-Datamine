// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureBookFillingWindow
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
  [Token(Token = "0x2001F6F")]
  [FlowNode.Pin(209, "画面を閉じる", FlowNode.PinTypes.Output, 209)]
  [AddComponentMenu("UI/Adventure/AdventureBookFillingWindow")]
  [FlowNode.Pin(201, "コンプリート演出の終了", FlowNode.PinTypes.Input, 201)]
  [FlowNode.Pin(105, "図鑑オープン演出をスキップ", FlowNode.PinTypes.Input, 105)]
  [FlowNode.Pin(101, "図鑑オープン演出の開始", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(9, "初期化完了", FlowNode.PinTypes.Output, 9)]
  [FlowNode.Pin(109, "図鑑オープン演出の終了", FlowNode.PinTypes.Output, 109)]
  public class AdventureBookFillingWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40084A2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x40084A3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject SkipButton;
    [Token(Token = "0x40084A4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Space(5f)]
    private Text TextBookHead;
    [Token(Token = "0x40084A5")]
    [FieldOffset(Offset = "0x18")]
    [Space(5f)]
    [SerializeField]
    private ContentController CcReward;
    [Token(Token = "0x40084A6")]
    [FieldOffset(Offset = "0x1C")]
    [Space(5f)]
    [SerializeField]
    private float WaitTime;
    [Token(Token = "0x40084A7")]
    [FieldOffset(Offset = "0x20")]
    [Space(5f)]
    private string StateAnimetionName;
    [Token(Token = "0x40084A8")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x40084A9")]
    private const int PIN_IN_ADV_START_OPEN_ANIMETION = 101;
    [Token(Token = "0x40084AA")]
    private const int PIN_IN_ADV_SKIP_OPEN_ANIMETION = 105;
    [Token(Token = "0x40084AB")]
    private const int PIN_IN_ADV_END_EFFECT = 201;
    [Token(Token = "0x40084AC")]
    private const int PIN_OUT_INIT = 9;
    [Token(Token = "0x40084AD")]
    private const int PIN_OUT_ADV_END_OPEN_ANIMETION = 109;
    [Token(Token = "0x40084AE")]
    private const int PIN_OUT_COMPLETE = 209;
    [Token(Token = "0x40084AF")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsComplete;
    [Token(Token = "0x40084B0")]
    [FieldOffset(Offset = "0x25")]
    private bool mResultSkipElement;
    [Token(Token = "0x40084B1")]
    [FieldOffset(Offset = "0x28")]
    private List<AdventureBookItemRewardParam> mBookItemRewardParamList;

    [Token(Token = "0x600811B")]
    [Address(RVA = "0x41AB50", Offset = "0x419950", VA = "0x1041AB50")]
    private void Awake()
    {
    }

    [Token(Token = "0x600811C")]
    [Address(RVA = "0x41AFA0", Offset = "0x419DA0", VA = "0x1041AFA0")]
    private void Init()
    {
    }

    [Token(Token = "0x600811D")]
    [Address(RVA = "0x41B020", Offset = "0x419E20", VA = "0x1041B020")]
    private bool Refresh() => new bool();

    [Token(Token = "0x600811E")]
    [Address(RVA = "0x41AC70", Offset = "0x419A70", VA = "0x1041AC70")]
    private void CreateReward(AdventureBook book)
    {
    }

    [Token(Token = "0x600811F")]
    [Address(RVA = "0x41AC00", Offset = "0x419A00", VA = "0x1041AC00", Slot = "5")]
    public virtual IEnumerator BookOpenAnimation() => (IEnumerator) null;

    [Token(Token = "0x6008120")]
    [Address(RVA = "0x41B2C0", Offset = "0x41A0C0", VA = "0x1041B2C0")]
    private IEnumerator StartIconEffect(AdventureBookItemRewardParam item, ContentGrid grid)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008121")]
    [Address(RVA = "0x41A9F0", Offset = "0x4197F0", VA = "0x1041A9F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008122")]
    [Address(RVA = "0x41B340", Offset = "0x41A140", VA = "0x1041B340")]
    public AdventureBookFillingWindow()
    {
    }
  }
}
