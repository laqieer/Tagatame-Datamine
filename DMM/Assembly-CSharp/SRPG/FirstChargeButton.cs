// Decompiled with JetBrains decompiler
// Type: SRPG.FirstChargeButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023B9")]
  [FlowNode.Pin(0, "Click FirstChargeEvent", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/FirstChargeButton")]
  public class FirstChargeButton : AppealItemBase, IFlowInterface
  {
    [Token(Token = "0x400A155")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string SPRITES_PATH;
    [Token(Token = "0x400A156")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string MASTER_PATH;
    [Token(Token = "0x400A157")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string CHARGEINFO_PATH;
    [Token(Token = "0x400A158")]
    [FieldOffset(Offset = "0xC")]
    private static readonly int INPUT_CLICK_CHARGE_EVENT;
    [Token(Token = "0x400A159")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject Badge;
    [Token(Token = "0x400A15A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Ballon;
    [Token(Token = "0x400A15B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool IsDebug;
    [Token(Token = "0x400A15C")]
    [FieldOffset(Offset = "0x20")]
    private string m_CurrentAppealId;
    [Token(Token = "0x400A15D")]
    [FieldOffset(Offset = "0x24")]
    private int m_CurrentAppealIndex;
    [Token(Token = "0x400A15E")]
    [FieldOffset(Offset = "0x28")]
    private List<AppealChargeParam> m_ValidAppeal;
    [Token(Token = "0x400A15F")]
    [FieldOffset(Offset = "0x2C")]
    private Dictionary<string, Sprite> mCacheAppealSprites;
    [Token(Token = "0x400A160")]
    [FieldOffset(Offset = "0x30")]
    private bool m_IsSpriteLoaded;
    [Token(Token = "0x400A161")]
    [FieldOffset(Offset = "0x34")]
    private GameObject m_ChargeInfoView;

    [Token(Token = "0x6009A91")]
    [Address(RVA = "0x5EA650", Offset = "0x5E9450", VA = "0x105EA650", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6009A92")]
    [Address(RVA = "0x5EAF60", Offset = "0x5E9D60", VA = "0x105EAF60", Slot = "5")]
    protected override void Start()
    {
    }

    [Token(Token = "0x6009A93")]
    [Address(RVA = "0x5EAC00", Offset = "0x5E9A00", VA = "0x105EAC00")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009A94")]
    [Address(RVA = "0x5EB040", Offset = "0x5E9E40", VA = "0x105EB040", Slot = "6")]
    protected override void Update()
    {
    }

    [Token(Token = "0x6009A95")]
    [Address(RVA = "0x5EAC10", Offset = "0x5E9A10", VA = "0x105EAC10", Slot = "9")]
    protected override void Refresh()
    {
    }

    [Token(Token = "0x6009A96")]
    [Address(RVA = "0x5EA540", Offset = "0x5E9340", VA = "0x105EA540", Slot = "10")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009A97")]
    [Address(RVA = "0x5EA690", Offset = "0x5E9490", VA = "0x105EA690")]
    private IEnumerator CreateInfoView() => (IEnumerator) null;

    [Token(Token = "0x6009A98")]
    [Address(RVA = "0x5EA750", Offset = "0x5E9550", VA = "0x105EA750")]
    private void InitMaster()
    {
    }

    [Token(Token = "0x6009A99")]
    [Address(RVA = "0x5EA800", Offset = "0x5E9600", VA = "0x105EA800")]
    private bool IsValidState(FirstChargeState _state) => new bool();

    [Token(Token = "0x6009A9A")]
    [Address(RVA = "0x5EADB0", Offset = "0x5E9BB0", VA = "0x105EADB0")]
    private void SetCurrentAppeal()
    {
    }

    [Token(Token = "0x6009A9B")]
    [Address(RVA = "0x5EA850", Offset = "0x5E9650", VA = "0x105EA850")]
    private bool LoadAppealMaster(string _path) => new bool();

    [Token(Token = "0x6009A9C")]
    [Address(RVA = "0x5EAB90", Offset = "0x5E9990", VA = "0x105EAB90")]
    private IEnumerator LoadAppealSprite(string _path) => (IEnumerator) null;

    [Token(Token = "0x6009A9D")]
    [Address(RVA = "0x5EA700", Offset = "0x5E9500", VA = "0x105EA700")]
    private IEnumerator CreateResultWindow() => (IEnumerator) null;

    [Token(Token = "0x6009A9E")]
    [Address(RVA = "0x5EB130", Offset = "0x5E9F30", VA = "0x105EB130")]
    public FirstChargeButton()
    {
    }

    [Token(Token = "0x6009A9F")]
    [Address(RVA = "0x5EB070", Offset = "0x5E9E70", VA = "0x105EB070")]
    static FirstChargeButton()
    {
    }
  }
}
