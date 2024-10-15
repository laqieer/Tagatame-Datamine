// Decompiled with JetBrains decompiler
// Type: SRPG.VersusDraftPartyEdit
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
  [Token(Token = "0x2002731")]
  [FlowNode.Pin(111, "Charged Party", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(20, "Finish", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(120, "To Map", FlowNode.PinTypes.Output, 21)]
  [AddComponentMenu("UI/Multi/Versus/Draft/VersusDraftPartyEdit")]
  [FlowNode.Pin(110, "Not Charged Party", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(10, "Reset", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(101, "Initialize Complete", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  public class VersusDraftPartyEdit : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B8D4")]
    private const int PARTY_SLOT_COUNT = 5;
    [Token(Token = "0x400B8D5")]
    private const int PARTY_ENABLE_COUNT = 3;
    [Token(Token = "0x400B8D6")]
    private const int INPUT_PIN_INITIALIZE = 1;
    [Token(Token = "0x400B8D7")]
    private const int OUTPUT_PIN_INITIALIZE = 101;
    [Token(Token = "0x400B8D8")]
    private const int INPUT_PIN_RESET = 10;
    [Token(Token = "0x400B8D9")]
    private const int OUTPUT_PIN_NOT_CHARGE = 110;
    [Token(Token = "0x400B8DA")]
    private const int OUTPUT_PIN_CHARGED = 111;
    [Token(Token = "0x400B8DB")]
    private const int INPUT_PIN_FINISH = 20;
    [Token(Token = "0x400B8DC")]
    private const int OUTPUT_PIN_TO_MAP = 120;
    [Token(Token = "0x400B8DD")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mPartyTransform;
    [Token(Token = "0x400B8DE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private VersusDraftPartySlot mUnitSlotItem;
    [Token(Token = "0x400B8DF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform mUnitTransform;
    [Token(Token = "0x400B8E0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private VersusDraftPartyUnit mUnitItem;
    [Token(Token = "0x400B8E1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mTotalAtk;
    [Token(Token = "0x400B8E2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mGOLeaderSkill;
    [Token(Token = "0x400B8E3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mTimerText;
    [Token(Token = "0x400B8E4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] enemyUnitLockList;
    [Token(Token = "0x400B8E5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private UnitIconEx[] enemyUnitIconExList;
    [Token(Token = "0x400B8E6")]
    [FieldOffset(Offset = "0x30")]
    private DataSource mLSDataSource;
    [Token(Token = "0x400B8E7")]
    [FieldOffset(Offset = "0x34")]
    private string mDefaultTotalAtkText;
    [Token(Token = "0x400B8E8")]
    [FieldOffset(Offset = "0x38")]
    private float mOrganizeSec;
    [Token(Token = "0x400B8E9")]
    [FieldOffset(Offset = "0x3C")]
    private float mTimer;
    [Token(Token = "0x400B8EA")]
    [FieldOffset(Offset = "0x40")]
    private bool mIsFinish;
    [Token(Token = "0x400B8EB")]
    [FieldOffset(Offset = "0x44")]
    private List<VersusDraftPartySlot> mVersusDraftPartySlotList;
    [Token(Token = "0x400B8EC")]
    [FieldOffset(Offset = "0x48")]
    private List<VersusDraftPartyUnit> mVersusDraftPartyUnitList;

    [Token(Token = "0x600AFBD")]
    [Address(RVA = "0x740B80", Offset = "0x73F980", VA = "0x10740B80")]
    private void Start()
    {
    }

    [Token(Token = "0x600AFBE")]
    [Address(RVA = "0x741490", Offset = "0x740290", VA = "0x10741490")]
    private void Update()
    {
    }

    [Token(Token = "0x600AFBF")]
    [Address(RVA = "0x740D10", Offset = "0x73FB10", VA = "0x10740D10")]
    private void Timeout()
    {
    }

    [Token(Token = "0x600AFC0")]
    [Address(RVA = "0x7402E0", Offset = "0x73F0E0", VA = "0x107402E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AFC1")]
    [Address(RVA = "0x740500", Offset = "0x73F300", VA = "0x10740500")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AFC2")]
    [Address(RVA = "0x740330", Offset = "0x73F130", VA = "0x10740330")]
    private void AllReset()
    {
    }

    [Token(Token = "0x600AFC3")]
    [Address(RVA = "0x740EF0", Offset = "0x73FCF0", VA = "0x10740EF0")]
    private void ToMap()
    {
    }

    [Token(Token = "0x600AFC4")]
    [Address(RVA = "0x7409A0", Offset = "0x73F7A0", VA = "0x107409A0")]
    public void SelectNextSlot()
    {
    }

    [Token(Token = "0x600AFC5")]
    [Address(RVA = "0x7410B0", Offset = "0x73FEB0", VA = "0x107410B0")]
    public void UpdateParty(bool is_leader)
    {
    }

    [Token(Token = "0x600AFC6")]
    [Address(RVA = "0x740490", Offset = "0x73F290", VA = "0x10740490")]
    private bool CheckBanUnit(UnitData unitData) => new bool();

    [Token(Token = "0x600AFC7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusDraftPartyEdit()
    {
    }
  }
}
