// Decompiled with JetBrains decompiler
// Type: SRPG.LoginBonusWindow28days
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
  [Token(Token = "0x20026F0")]
  [FlowNode.Pin(11, "Take Bonus", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(16, "Message Closed", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(14, "詳細表示（アイテム）", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(13, "Taked", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(12, "Last Day", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(10, "Load Complete", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("UI/LoginBonusWindow28days")]
  [FlowNode.Pin(15, "詳細表示（真理念装）", FlowNode.PinTypes.Output, 5)]
  public class LoginBonusWindow28days : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B72B")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ItemList;
    [Token(Token = "0x400B72C")]
    [FieldOffset(Offset = "0x10")]
    public GameObject[] PositionList;
    [Token(Token = "0x400B72D")]
    [FieldOffset(Offset = "0x14")]
    [HeaderBar("▼アイコン表示用オブジェクト")]
    public ListItemEvents Item_Normal;
    [Token(Token = "0x400B72E")]
    [FieldOffset(Offset = "0x18")]
    public ListItemEvents Item_Taken;
    [Token(Token = "0x400B72F")]
    [FieldOffset(Offset = "0x1C")]
    public Json_LoginBonus[] DebugItems;
    [Token(Token = "0x400B730")]
    [FieldOffset(Offset = "0x20")]
    public int DebugBonusCount;
    [Token(Token = "0x400B731")]
    [FieldOffset(Offset = "0x24")]
    private int mLoginBonusCount;
    [Token(Token = "0x400B732")]
    [FieldOffset(Offset = "0x28")]
    public GameObject BonusParticleEffect;
    [Token(Token = "0x400B733")]
    [FieldOffset(Offset = "0x2C")]
    [HeaderBar("▼演出時のアイコン表示用オブジェクト")]
    public GameObject LastItem;
    [Token(Token = "0x400B734")]
    [FieldOffset(Offset = "0x30")]
    public GameObject TodayItem;
    [Token(Token = "0x400B735")]
    [FieldOffset(Offset = "0x34")]
    public GameObject TommorowItem;
    [Token(Token = "0x400B736")]
    [FieldOffset(Offset = "0x38")]
    public RectTransform TodayBadge;
    [Token(Token = "0x400B737")]
    [FieldOffset(Offset = "0x3C")]
    public RectTransform TommorowBadge;
    [Token(Token = "0x400B738")]
    [FieldOffset(Offset = "0x40")]
    public string CheckName;
    [Token(Token = "0x400B739")]
    [FieldOffset(Offset = "0x44")]
    public string[] DisabledFirstDayNames;
    [Token(Token = "0x400B73A")]
    [FieldOffset(Offset = "0x48")]
    public string TableID;
    [Token(Token = "0x400B73B")]
    [FieldOffset(Offset = "0x4C")]
    public List<Toggle> WeakToggle;
    [Token(Token = "0x400B73C")]
    [FieldOffset(Offset = "0x50")]
    public Text GainLastItemMessage;
    [Token(Token = "0x400B73D")]
    [FieldOffset(Offset = "0x54")]
    public Text PopupMessage;
    [Token(Token = "0x400B73E")]
    [FieldOffset(Offset = "0x58")]
    public GameObject RemainingCounter;
    [Token(Token = "0x400B73F")]
    [FieldOffset(Offset = "0x5C")]
    public Text RemainingCount;
    [Token(Token = "0x400B740")]
    [FieldOffset(Offset = "0x60")]
    [HeaderBar("▼3Dモデル表示用")]
    public Transform PreviewParent;
    [Token(Token = "0x400B741")]
    [FieldOffset(Offset = "0x64")]
    public RawImage PreviewImage;
    [Token(Token = "0x400B742")]
    [FieldOffset(Offset = "0x68")]
    public UnityEngine.Camera PreviewCamera;
    [Token(Token = "0x400B743")]
    [FieldOffset(Offset = "0x6C")]
    public float PreviewCameraDistance;
    [Token(Token = "0x400B744")]
    [FieldOffset(Offset = "0x70")]
    public bool IsConfigWindow;
    [Token(Token = "0x400B745")]
    [FieldOffset(Offset = "0x74")]
    public string DebugNotifyUnitID;
    [Token(Token = "0x400B746")]
    [FieldOffset(Offset = "0x78")]
    public LoginBonusWindow Message;
    [Token(Token = "0x400B747")]
    [FieldOffset(Offset = "0x7C")]
    public float MessageDelay;
    [Token(Token = "0x400B748")]
    [FieldOffset(Offset = "0x80")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400B749")]
    [FieldOffset(Offset = "0x84")]
    private UnitPreview mCurrentPreview;
    [Token(Token = "0x400B74A")]
    [FieldOffset(Offset = "0x88")]
    private RenderTexture mPreviewUnitRT;
    [Token(Token = "0x400B74B")]
    [FieldOffset(Offset = "0x8C")]
    private LoginBonusWindow mMessageWindow;
    [Token(Token = "0x400B74C")]
    [FieldOffset(Offset = "0x90")]
    private List<ListItemEvents> mItems;
    [Token(Token = "0x400B74D")]
    [FieldOffset(Offset = "0x94")]
    private int mCurrentWeak;
    [Token(Token = "0x400B74E")]
    [FieldOffset(Offset = "0x98")]
    private string[] mNotifyUnits;

    [Token(Token = "0x600AE60")]
    [Address(RVA = "0x7229F0", Offset = "0x7217F0", VA = "0x107229F0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AE61")]
    [Address(RVA = "0x723410", Offset = "0x722210", VA = "0x10723410")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AE62")]
    [Address(RVA = "0x722BD0", Offset = "0x7219D0", VA = "0x10722BD0")]
    private void DisableFirstDayHiddenOject(GameObject parent)
    {
    }

    [Token(Token = "0x600AE63")]
    [Address(RVA = "0x7232D0", Offset = "0x7220D0", VA = "0x107232D0")]
    private string GetPopupMessage(GiftRecieveItemData item) => (string) null;

    [Token(Token = "0x600AE64")]
    [Address(RVA = "0x723200", Offset = "0x722000", VA = "0x10723200")]
    private string GetGainLastItemMessage(GiftRecieveItemData item) => (string) null;

    [Token(Token = "0x600AE65")]
    [Address(RVA = "0x723940", Offset = "0x722740", VA = "0x10723940")]
    private void Start()
    {
    }

    [Token(Token = "0x600AE66")]
    [Address(RVA = "0x724DC0", Offset = "0x723BC0", VA = "0x10724DC0")]
    private IEnumerator WaitLoadAsync() => (IEnumerator) null;

    [Token(Token = "0x600AE67")]
    [Address(RVA = "0x7229D0", Offset = "0x7217D0", VA = "0x107229D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AE68")]
    [Address(RVA = "0x722D00", Offset = "0x721B00", VA = "0x10722D00")]
    private void FlipTodaysItem()
    {
    }

    [Token(Token = "0x600AE69")]
    [Address(RVA = "0x7236A0", Offset = "0x7224A0", VA = "0x107236A0")]
    private void OnWeakSelect(GameObject go)
    {
    }

    [Token(Token = "0x600AE6A")]
    [Address(RVA = "0x723540", Offset = "0x722340", VA = "0x10723540")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600AE6B")]
    [Address(RVA = "0x722B60", Offset = "0x721960", VA = "0x10722B60")]
    private IEnumerator DelayPopupMessage() => (IEnumerator) null;

    [Token(Token = "0x600AE6C")]
    [Address(RVA = "0x724D50", Offset = "0x723B50", VA = "0x10724D50")]
    private IEnumerator WaitForDestroy() => (IEnumerator) null;

    [Token(Token = "0x600AE6D")]
    [Address(RVA = "0x724E30", Offset = "0x723C30", VA = "0x10724E30")]
    public LoginBonusWindow28days()
    {
    }
  }
}
