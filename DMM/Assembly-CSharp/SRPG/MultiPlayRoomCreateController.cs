// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayRoomCreateController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200278F")]
  [AddComponentMenu("UI/MultiPlayRoomCreateController")]
  [FlowNode.Pin(1, "バトルスピード表示更新", FlowNode.PinTypes.Input, 1)]
  public class MultiPlayRoomCreateController : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BAC8")]
    private const int PIN_INPUT_REFRESH_BATTLE_SPEED = 1;
    [Token(Token = "0x400BAC9")]
    [FieldOffset(Offset = "0xC")]
    public Toggle PassToggle;
    [Token(Token = "0x400BACA")]
    [FieldOffset(Offset = "0x10")]
    public Toggle LimitToggle;
    [Token(Token = "0x400BACB")]
    [FieldOffset(Offset = "0x14")]
    public Toggle ClearToggle;
    [Token(Token = "0x400BACC")]
    [FieldOffset(Offset = "0x18")]
    public GameObject Filter;
    [Token(Token = "0x400BACD")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ClearEnableButton;
    [Token(Token = "0x400BACE")]
    [FieldOffset(Offset = "0x20")]
    public GameObject ClearDisableButton;
    [Token(Token = "0x400BACF")]
    [FieldOffset(Offset = "0x24")]
    public GameObject LimitEnableButton;
    [Token(Token = "0x400BAD0")]
    [FieldOffset(Offset = "0x28")]
    public GameObject LimitDisableButton;
    [Token(Token = "0x400BAD1")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject DetailFilter;
    [Token(Token = "0x400BAD2")]
    [FieldOffset(Offset = "0x30")]
    public ScrollablePulldown UnitLvPulldown;
    [Token(Token = "0x400BAD3")]
    [FieldOffset(Offset = "0x34")]
    public GraphicsRaycasterExtend UnitPulldownBG;
    [Token(Token = "0x400BAD4")]
    [FieldOffset(Offset = "0x38")]
    public ScrollablePulldown BattleSpeedPulldown;
    [Token(Token = "0x400BAD5")]
    [FieldOffset(Offset = "0x3C")]
    public GraphicsRaycasterExtend BattleSpeedPulldownBG;
    [Token(Token = "0x400BAD6")]
    [FieldOffset(Offset = "0x40")]
    private int mMaxLv;
    [Token(Token = "0x400BAD7")]
    [FieldOffset(Offset = "0x44")]
    private int mNowSelIdx;

    [Token(Token = "0x600B16F")]
    [Address(RVA = "0x7576D0", Offset = "0x7564D0", VA = "0x107576D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B170")]
    [Address(RVA = "0x758BB0", Offset = "0x7579B0", VA = "0x10758BB0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B171")]
    [Address(RVA = "0x7584D0", Offset = "0x7572D0", VA = "0x107584D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B172")]
    [Address(RVA = "0x7579D0", Offset = "0x7567D0", VA = "0x107579D0")]
    public void OnEnablePass()
    {
    }

    [Token(Token = "0x600B173")]
    [Address(RVA = "0x757840", Offset = "0x756640", VA = "0x10757840")]
    public void OnDisablePass()
    {
    }

    [Token(Token = "0x600B174")]
    [Address(RVA = "0x757930", Offset = "0x756730", VA = "0x10757930")]
    public void OnEnableLimit()
    {
    }

    [Token(Token = "0x600B175")]
    [Address(RVA = "0x7577A0", Offset = "0x7565A0", VA = "0x107577A0")]
    public void OnDisableLimit()
    {
    }

    [Token(Token = "0x600B176")]
    [Address(RVA = "0x7578E0", Offset = "0x7566E0", VA = "0x107578E0")]
    public void OnEnableClear()
    {
    }

    [Token(Token = "0x600B177")]
    [Address(RVA = "0x757750", Offset = "0x756550", VA = "0x10757750")]
    public void OnDisableClear()
    {
    }

    [Token(Token = "0x600B178")]
    [Address(RVA = "0x757C80", Offset = "0x756A80", VA = "0x10757C80")]
    private void OnUnitLvChange(int index)
    {
    }

    [Token(Token = "0x600B179")]
    [Address(RVA = "0x757AF0", Offset = "0x7568F0", VA = "0x10757AF0")]
    public void OnPassToggle(bool isOn)
    {
    }

    [Token(Token = "0x600B17A")]
    [Address(RVA = "0x757A40", Offset = "0x756840", VA = "0x10757A40")]
    public void OnLimitToggle(bool isOn)
    {
    }

    [Token(Token = "0x600B17B")]
    [Address(RVA = "0x7576F0", Offset = "0x7564F0", VA = "0x107576F0")]
    public void OnClearToggle(bool isOn)
    {
    }

    [Token(Token = "0x600B17C")]
    [Address(RVA = "0x758B00", Offset = "0x757900", VA = "0x10758B00")]
    private void SetBattleSpeed(int index)
    {
    }

    [Token(Token = "0x600B17D")]
    [Address(RVA = "0x757E00", Offset = "0x756C00", VA = "0x10757E00")]
    private void RefreshBattleSpeed()
    {
    }

    [Token(Token = "0x600B17E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MultiPlayRoomCreateController()
    {
    }
  }
}
