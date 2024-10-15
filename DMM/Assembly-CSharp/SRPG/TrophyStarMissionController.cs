// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyStarMissionController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B71")]
  [AddComponentMenu("UI/Trophy/TrophyStarMissionController")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "Daily宝箱を選択", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "Weekly宝箱を選択", FlowNode.PinTypes.Output, 102)]
  public class TrophyStarMissionController : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D4AD")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x400D4AE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Space(5f)]
    private Text DailyStarNum;
    [Token(Token = "0x400D4AF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject DailyGoSelParent;
    [Token(Token = "0x400D4B0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TrophyStarMissionDailyItem DailySelItemTemplate;
    [Token(Token = "0x400D4B1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Slider DailyStarPointGauge;
    [Token(Token = "0x400D4B2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Space(5f)]
    private GameObject DailyBulkClearMsgObj;
    [Token(Token = "0x400D4B3")]
    [FieldOffset(Offset = "0x24")]
    [Space(5f)]
    [SerializeField]
    private Text WeeklyStarNum;
    [Token(Token = "0x400D4B4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TrophyStarMissionWeeklyItem[] WeeklyItems;
    [Token(Token = "0x400D4B5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text WeeklyEndDate;
    [Token(Token = "0x400D4B6")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400D4B7")]
    private const int PIN_IN_REFRESH = 2;
    [Token(Token = "0x400D4B8")]
    private const int PIN_OUT_DAILY_TREASURE_SELECTED = 101;
    [Token(Token = "0x400D4B9")]
    private const int PIN_OUT_WEEKLY_TREASURE_SELECTED = 102;
    [Token(Token = "0x400D4BA")]
    [FieldOffset(Offset = "0x30")]
    private TrophyWindow mTrophyWindowComponent;

    [Token(Token = "0x17001A67")]
    private TrophyWindow TrophyWindowComponent
    {
      [Token(Token = "0x600C706"), Address(RVA = "0x903D20", Offset = "0x902B20", VA = "0x10903D20")] get
      {
        return (TrophyWindow) null;
      }
    }

    [Token(Token = "0x600C707")]
    [Address(RVA = "0x903040", Offset = "0x901E40", VA = "0x10903040")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C708")]
    [Address(RVA = "0x9030A0", Offset = "0x901EA0", VA = "0x109030A0")]
    private void Init()
    {
    }

    [Token(Token = "0x600C709")]
    [Address(RVA = "0x903240", Offset = "0x902040", VA = "0x10903240")]
    private void Refresh(bool is_init = false)
    {
    }

    [Token(Token = "0x600C70A")]
    [Address(RVA = "0x903100", Offset = "0x901F00", VA = "0x10903100")]
    public void OnDailySelectItem(TrophyStarMissionDailyItem item)
    {
    }

    [Token(Token = "0x600C70B")]
    [Address(RVA = "0x9031A0", Offset = "0x901FA0", VA = "0x109031A0")]
    public void OnWeeklySelectItem(TrophyStarMissionWeeklyItem item)
    {
    }

    [Token(Token = "0x600C70C")]
    [Address(RVA = "0x902FC0", Offset = "0x901DC0", VA = "0x10902FC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C70D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TrophyStarMissionController()
    {
    }
  }
}
