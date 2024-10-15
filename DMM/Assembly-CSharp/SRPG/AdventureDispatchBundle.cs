// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureDispatchBundle
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
  [Token(Token = "0x2001F92")]
  [AddComponentMenu("UI/Adventure/AdventureDispatchBundle")]
  [FlowNode.Pin(104, "派遣中止", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(103, "派遣メニュー表示へ", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(105, "アイテム使用", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(102, "派遣開始通信へ(スタミナ不足)", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(1, "初回表示処理", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "派遣開始通信へ", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(12, "派遣メニュー設定処理", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "派遣開始設定処理", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(15, "アイテム使用設定処理", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(14, "派遣中止設定処理", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(13, "派遣完了設定処理", FlowNode.PinTypes.Input, 13)]
  public class AdventureDispatchBundle : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008544")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008545")]
    private const int PIN_INPUT_ADVENTURE_START = 11;
    [Token(Token = "0x4008546")]
    private const int PIN_INPUT_ADVENTURE_MENU = 12;
    [Token(Token = "0x4008547")]
    private const int PIN_INPUT_ADVENTURE_END = 13;
    [Token(Token = "0x4008548")]
    private const int PIN_INPUT_ADVENTURE_STOP = 14;
    [Token(Token = "0x4008549")]
    private const int PIN_INPUT_ADVENTURE_ITEM = 15;
    [Token(Token = "0x400854A")]
    private const int PIN_OUTPUT_ADVENTURE_START = 101;
    [Token(Token = "0x400854B")]
    private const int PIN_OUTPUT_ADVENTURE_AP_RECOVER = 102;
    [Token(Token = "0x400854C")]
    private const int PIN_OUTPUT_ADVENTURE_MENU = 103;
    [Token(Token = "0x400854D")]
    private const int PIN_OUTPUT_ADVENTURE_STOP = 104;
    [Token(Token = "0x400854E")]
    private const int PIN_OUTPUT_ADVENTURE_ITEM = 105;
    [Token(Token = "0x400854F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentController CController;
    [Token(Token = "0x4008550")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text NowAdventureCount;
    [Token(Token = "0x4008551")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text MaxAdventureCount;
    [Token(Token = "0x4008552")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform AdventureMenuObj;
    [Token(Token = "0x4008553")]
    [FieldOffset(Offset = "0x1C")]
    private AdventureManager mManager;
    [Token(Token = "0x4008554")]
    [FieldOffset(Offset = "0x20")]
    private AdventureRecommend mRecommend;
    [Token(Token = "0x4008555")]
    [FieldOffset(Offset = "0x24")]
    private List<AdventureData> mDataList;
    [Token(Token = "0x4008556")]
    [FieldOffset(Offset = "0x28")]
    private List<AdventureDispatchItemParam> mNodeList;
    [Token(Token = "0x4008557")]
    [FieldOffset(Offset = "0x2C")]
    private AdventureData mSelectData;
    [Token(Token = "0x4008558")]
    [FieldOffset(Offset = "0x30")]
    private bool IsSkipMovieSetting;

    [Token(Token = "0x60081AB")]
    [Address(RVA = "0x420B50", Offset = "0x41F950", VA = "0x10420B50")]
    private void Start()
    {
    }

    [Token(Token = "0x60081AC")]
    [Address(RVA = "0x420080", Offset = "0x41EE80", VA = "0x10420080")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60081AD")]
    [Address(RVA = "0x41FBC0", Offset = "0x41E9C0", VA = "0x1041FBC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60081AE")]
    [Address(RVA = "0x41FF60", Offset = "0x41ED60", VA = "0x1041FF60")]
    private void Init()
    {
    }

    [Token(Token = "0x60081AF")]
    [Address(RVA = "0x4200E0", Offset = "0x41EEE0", VA = "0x104200E0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60081B0")]
    [Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")]
    public void SelectTeam(AdventureData _data)
    {
    }

    [Token(Token = "0x60081B1")]
    [Address(RVA = "0x420AE0", Offset = "0x41F8E0", VA = "0x10420AE0")]
    private void StartAdventureData()
    {
    }

    [Token(Token = "0x60081B2")]
    [Address(RVA = "0x41FF00", Offset = "0x41ED00", VA = "0x1041FF00")]
    private void AdventureEnd()
    {
    }

    [Token(Token = "0x60081B3")]
    [Address(RVA = "0x420BD0", Offset = "0x41F9D0", VA = "0x10420BD0")]
    public AdventureDispatchBundle()
    {
    }
  }
}
