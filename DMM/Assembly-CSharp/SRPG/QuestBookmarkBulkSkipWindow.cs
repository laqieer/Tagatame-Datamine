// Decompiled with JetBrains decompiler
// Type: SRPG.QuestBookmarkBulkSkipWindow
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
  [Token(Token = "0x20020DA")]
  [AddComponentMenu("UI/Bookmark/QuestBookmarkBulkSkipWindow")]
  [FlowNode.Pin(201, "予期せぬエラー検知", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(2, "スキップ完了", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(102, "リザルト表示", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "初期化完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(104, "リザルト終了", FlowNode.PinTypes.Output, 104)]
  public class QuestBookmarkBulkSkipWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008DD0")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008DD1")]
    private const int PIN_INPUT_BULK_SKIP_FIN = 2;
    [Token(Token = "0x4008DD2")]
    private const int PIN_OUTPUT_INIT_FINISH = 101;
    [Token(Token = "0x4008DD3")]
    private const int PIN_OUTPUT_RESLT_START = 102;
    [Token(Token = "0x4008DD4")]
    private const int PIN_OUTPUT_SHOW_RESULT_END = 104;
    [Token(Token = "0x4008DD5")]
    private const int PIN_OUTPUT_ERROR = 201;
    [Token(Token = "0x4008DD6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private BitmapText mNeedApNumTxt;
    [Token(Token = "0x4008DD7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private BitmapText mNeedSkipItemNumTxt;
    [Token(Token = "0x4008DD8")]
    [FieldOffset(Offset = "0x14")]
    [StringIsResourcePath(typeof (RaidResultWindow))]
    [SerializeField]
    private string mRaidResultPrefab;
    [Token(Token = "0x4008DD9")]
    [FieldOffset(Offset = "0x0")]
    private static QuestBookmarkBulkSkipWindow mInstance;
    [Token(Token = "0x4008DDA")]
    [FieldOffset(Offset = "0x18")]
    private LoadRequest mReqRaidResultWindow;
    [Token(Token = "0x4008DDB")]
    [FieldOffset(Offset = "0x1C")]
    private int mGold;
    [Token(Token = "0x4008DDC")]
    [FieldOffset(Offset = "0x20")]
    private BattleCore.Json_BtlDrop[] mBulkSkipDrop;
    [Token(Token = "0x4008DDD")]
    [FieldOffset(Offset = "0x24")]
    private List<RuneData> mRuneDatas;
    [Token(Token = "0x4008DDE")]
    [FieldOffset(Offset = "0x28")]
    private List<Json_Disassemble> runes_disassemble;
    [Token(Token = "0x4008DDF")]
    [FieldOffset(Offset = "0x2C")]
    private List<UnitData> old_units;
    [Token(Token = "0x4008DE0")]
    [FieldOffset(Offset = "0x30")]
    private int old_player_lv;
    [Token(Token = "0x4008DE1")]
    [FieldOffset(Offset = "0x34")]
    private int old_player_exp;

    [Token(Token = "0x17001358")]
    public static QuestBookmarkBulkSkipWindow Instance
    {
      [Token(Token = "0x60088FF"), Address(RVA = "0x4AEE60", Offset = "0x4ADC60", VA = "0x104AEE60")] get
      {
        return (QuestBookmarkBulkSkipWindow) null;
      }
    }

    [Token(Token = "0x6008900")]
    [Address(RVA = "0x4ADFA0", Offset = "0x4ACDA0", VA = "0x104ADFA0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008901")]
    [Address(RVA = "0x4AE560", Offset = "0x4AD360", VA = "0x104AE560")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008902")]
    [Address(RVA = "0x4ADF70", Offset = "0x4ACD70", VA = "0x104ADF70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008903")]
    [Address(RVA = "0x4AE5A0", Offset = "0x4AD3A0", VA = "0x104AE5A0")]
    public void SetBulkSkipResultData(ReqBookmarkBulkSkip.Response response)
    {
    }

    [Token(Token = "0x6008904")]
    [Address(RVA = "0x4AE240", Offset = "0x4AD040", VA = "0x104AE240")]
    private void Initialized()
    {
    }

    [Token(Token = "0x6008905")]
    [Address(RVA = "0x4AE790", Offset = "0x4AD590", VA = "0x104AE790")]
    private void SetQuestResultData()
    {
    }

    [Token(Token = "0x6008906")]
    [Address(RVA = "0x4AED20", Offset = "0x4ADB20", VA = "0x104AED20")]
    private IEnumerator ShowResultAsync() => (IEnumerator) null;

    [Token(Token = "0x6008907")]
    [Address(RVA = "0x4ADFE0", Offset = "0x4ACDE0", VA = "0x104ADFE0")]
    private List<QuestResult.DropItemData> GetSortDropResultData()
    {
      return (List<QuestResult.DropItemData>) null;
    }

    [Token(Token = "0x6008908")]
    [Address(RVA = "0x4AEDF0", Offset = "0x4ADBF0", VA = "0x104AEDF0")]
    public QuestBookmarkBulkSkipWindow()
    {
    }
  }
}
