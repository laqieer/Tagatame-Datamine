// Decompiled with JetBrains decompiler
// Type: SRPG.PlayerUnitSelectWindow
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
  [Token(Token = "0x2002C23")]
  [AddComponentMenu("UI/Filter/PlayerUnitSelectWindow")]
  [FlowNode.Pin(101, "閉じる", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(5, "ユニット選択初期化", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(4, "ユニット選択", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "フィルタークリア", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "保存して終了", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class PlayerUnitSelectWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400DA35")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400DA36")]
    public const int PIN_INPUT_CKICK_CLOSE = 2;
    [Token(Token = "0x400DA37")]
    public const int PIN_INPUT_FILTER_CLEAR = 3;
    [Token(Token = "0x400DA38")]
    public const int PIN_INPUT_UNIT_SELECT = 4;
    [Token(Token = "0x400DA39")]
    public const int PIN_INPUT_INITUNITSELECT = 5;
    [Token(Token = "0x400DA3A")]
    public const int PIN_OUTPUT_CLOSE = 101;
    [Token(Token = "0x400DA3B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public GameObject mUnitTemplete;
    [Token(Token = "0x400DA3C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public ContentController mContentController;
    [Token(Token = "0x400DA3D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public Toggle mFilterHaveUnitCheck;
    [Token(Token = "0x400DA3E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public Toggle mToggleElementNone;
    [Token(Token = "0x400DA3F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public Toggle mToggleElementFire;
    [Token(Token = "0x400DA40")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public Toggle mToggleElementWater;
    [Token(Token = "0x400DA41")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public Toggle mToggleElementThunder;
    [Token(Token = "0x400DA42")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public Toggle mToggleElementWind;
    [Token(Token = "0x400DA43")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public Toggle mToggleElementShine;
    [Token(Token = "0x400DA44")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public Toggle mToggleElementDark;
    [Token(Token = "0x400DA45")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public bool OneSelectUnitMode;
    [Token(Token = "0x400DA46")]
    [FieldOffset(Offset = "0x35")]
    [SerializeField]
    public bool IsIgnoreUnit;
    [Token(Token = "0x400DA47")]
    public const string KEY_PLAYER_SELECT_UNITS = "KEY_PLAYER_SELECT_UNITS";
    [Token(Token = "0x400DA48")]
    public const string KEY_PLAYER_SELECT_UNIT = "KEY_PLAYER_SELECT_UNIT";
    [Token(Token = "0x400DA49")]
    [FieldOffset(Offset = "0x38")]
    public List<BondFilterContentParam> mBondFilterContentParams;
    [Token(Token = "0x400DA4A")]
    [FieldOffset(Offset = "0x3C")]
    public Vector2 mAnchorPosition;
    [Token(Token = "0x400DA4B")]
    [FieldOffset(Offset = "0x44")]
    public bool mIsHaveUnitOnly;
    [Token(Token = "0x400DA4C")]
    [FieldOffset(Offset = "0x48")]
    public List<string> mFilterUnitInames;
    [Token(Token = "0x400DA4D")]
    [FieldOffset(Offset = "0x4C")]
    public List<string> mHaveUnitInames;
    [Token(Token = "0x400DA4E")]
    [FieldOffset(Offset = "0x50")]
    public List<string> mSelectUnitInames;
    [Token(Token = "0x400DA4F")]
    [FieldOffset(Offset = "0x54")]
    public EElement mSelectElement;
    [Token(Token = "0x400DA50")]
    public const string UNITFILTERSVB = "UNITFILTERSVB";

    [Token(Token = "0x600CC3F")]
    [Address(RVA = "0x9689D0", Offset = "0x9677D0", VA = "0x109689D0")]
    private void Start()
    {
    }

    [Token(Token = "0x600CC40")]
    [Address(RVA = "0x967690", Offset = "0x966490", VA = "0x10967690", Slot = "6")]
    public virtual void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CC41")]
    [Address(RVA = "0x9677B0", Offset = "0x9665B0", VA = "0x109677B0", Slot = "7")]
    public virtual void Initialized()
    {
    }

    [Token(Token = "0x600CC42")]
    [Address(RVA = "0x968410", Offset = "0x967210", VA = "0x10968410", Slot = "8")]
    public virtual void Refresh()
    {
    }

    [Token(Token = "0x600CC43")]
    [Address(RVA = "0x967F80", Offset = "0x966D80", VA = "0x10967F80")]
    public void OnChageValueHaveUnitOnly(bool isOn)
    {
    }

    [Token(Token = "0x600CC44")]
    [Address(RVA = "0x967F50", Offset = "0x966D50", VA = "0x10967F50")]
    public void OnChageValueElementTab(bool isOn, EElement element)
    {
    }

    [Token(Token = "0x600CC45")]
    [Address(RVA = "0x967FB0", Offset = "0x966DB0", VA = "0x10967FB0")]
    public void OnClickFilterClear()
    {
    }

    [Token(Token = "0x600CC46")]
    [Address(RVA = "0x968130", Offset = "0x966F30", VA = "0x10968130")]
    public void OnClickUnitSelect(string unit_iname)
    {
    }

    [Token(Token = "0x600CC47")]
    [Address(RVA = "0x968390", Offset = "0x967190", VA = "0x10968390", Slot = "9")]
    public virtual bool OnFinishSave() => new bool();

    [Token(Token = "0x600CC48")]
    [Address(RVA = "0x967F00", Offset = "0x966D00", VA = "0x10967F00")]
    public bool IsSelectUnit(string unit_iname) => new bool();

    [Token(Token = "0x600CC49")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600CC4A")]
    [Address(RVA = "0x968C20", Offset = "0x967A20", VA = "0x10968C20")]
    public PlayerUnitSelectWindow()
    {
    }
  }
}
