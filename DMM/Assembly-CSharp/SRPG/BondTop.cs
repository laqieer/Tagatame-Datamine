// Decompiled with JetBrains decompiler
// Type: SRPG.BondTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020D0")]
  [FlowNode.Pin(104, "チップス確認", FlowNode.PinTypes.Output, 104)]
  [AddComponentMenu("UI/Bond/BondTop")]
  [FlowNode.Pin(106, "ロック解除アニメ再生終了", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(105, "ロック解除アニメ再生", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(103, "グループ切り替え完了", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "グループ選択", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(13, "グループロック解除", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(12, "フィルターLvUP可能のみ - OFF", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "フィルターLvUP可能のみ - ON", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(3, "グループ切り替え", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "表示更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(102, "該当メンバー", FlowNode.PinTypes.Output, 102)]
  public class BondTop : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008DA4")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008DA5")]
    private const int PIN_INPUT_REFRESH = 2;
    [Token(Token = "0x4008DA6")]
    private const int PIN_INPUT_CYCLE_GROUP = 3;
    [Token(Token = "0x4008DA7")]
    private const int PIN_INPUT_FILTER_CAN_LVUP_ON = 11;
    [Token(Token = "0x4008DA8")]
    private const int PIN_INPUT_FILTER_CAN_LVUP_OFF = 12;
    [Token(Token = "0x4008DA9")]
    private const int PIN_INPUT_OPEN_GROUP = 13;
    [Token(Token = "0x4008DAA")]
    private const int PIN_OUTPUT_SELECT_GROUP = 101;
    [Token(Token = "0x4008DAB")]
    private const int PIN_OUTPUT_TARGET_MEMBER = 102;
    [Token(Token = "0x4008DAC")]
    private const int PIN_OUTPUT_CYCLE_FINISH = 103;
    [Token(Token = "0x4008DAD")]
    private const int PIN_OUTPUT_TIPS_VERIFY = 104;
    [Token(Token = "0x4008DAE")]
    private const int PIN_OUTPUT_OPEN_GROUP = 105;
    [Token(Token = "0x4008DAF")]
    private const int PIN_OUTPUT_OPEN_GROUP_FINISH = 106;
    [Token(Token = "0x4008DB0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string REWARD_ICON_PREFAB_PATH;
    [Token(Token = "0x4008DB1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x4008DB2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle mIsCanLvUpToggle;
    [Token(Token = "0x4008DB3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ImageArray mUnitFilterBg;
    [Token(Token = "0x4008DB4")]
    [FieldOffset(Offset = "0x1C")]
    [HeaderBar("▼解放演出用")]
    [SerializeField]
    private float mAutoScrollSec;
    [Token(Token = "0x4008DB5")]
    [FieldOffset(Offset = "0x0")]
    private static BondTop mInstance;
    [Token(Token = "0x4008DB6")]
    [FieldOffset(Offset = "0x20")]
    private List<BondMissionData> mBondMissionDatas;
    [Token(Token = "0x4008DB7")]
    [FieldOffset(Offset = "0x24")]
    private BondGroupParam mSelectBondGroup;
    [Token(Token = "0x4008DB8")]
    [FieldOffset(Offset = "0x28")]
    private List<string> mFilterUnitInames;
    [Token(Token = "0x4008DB9")]
    [FieldOffset(Offset = "0x2C")]
    private List<SRPG.BondMaterialDatas> mBondMaterialDatas;
    [Token(Token = "0x4008DBA")]
    [FieldOffset(Offset = "0x30")]
    private List<int> mNewOpenBannerIndex;
    [Token(Token = "0x4008DBB")]
    [FieldOffset(Offset = "0x34")]
    private List<BondContentParam> mBondContentParams;
    [Token(Token = "0x4008DBC")]
    [FieldOffset(Offset = "0x38")]
    private SRPG.StateMachine<BondTop> StateMachine;
    [Token(Token = "0x4008DBD")]
    [FieldOffset(Offset = "0x3C")]
    private bool mIsFilterCanLvUpOnly;
    [Token(Token = "0x4008DBE")]
    [FieldOffset(Offset = "0x40")]
    private List<BondGroupParam> mOpenGroupParamList;
    [Token(Token = "0x4008DBF")]
    [FieldOffset(Offset = "0x44")]
    [NonSerialized]
    public BondGroupBuffDetaillParam SelectBondGroupBuffDetaill;
    [Token(Token = "0x4008DC0")]
    [FieldOffset(Offset = "0x48")]
    [NonSerialized]
    public string BondMissionRewardSelectIname;
    [Token(Token = "0x4008DC1")]
    [FieldOffset(Offset = "0x4C")]
    [NonSerialized]
    public int GroupIndex;

    [Token(Token = "0x17001350")]
    public static BondTop Instance
    {
      [Token(Token = "0x60088BD"), Address(RVA = "0x4A1170", Offset = "0x49FF70", VA = "0x104A1170")] get
      {
        return (BondTop) null;
      }
    }

    [Token(Token = "0x17001351")]
    public List<SRPG.BondMaterialDatas> BondMaterialDatas
    {
      [Token(Token = "0x60088BE"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (List<SRPG.BondMaterialDatas>) null;
      }
    }

    [Token(Token = "0x17001352")]
    public List<BondMissionData> BondMissionDatas
    {
      [Token(Token = "0x60088BF"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<BondMissionData>) null;
      }
    }

    [Token(Token = "0x17001353")]
    public BondGroupParam SelectBondGroup
    {
      [Token(Token = "0x60088C0"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (BondGroupParam) null;
      }
    }

    [Token(Token = "0x17001354")]
    public List<string> FilterUnitInames
    {
      [Token(Token = "0x60088C1"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17001355")]
    public ContentController ContentController
    {
      [Token(Token = "0x60088C2"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ContentController) null;
      }
    }

    [Token(Token = "0x17001356")]
    public List<int> NewOpenBannerIndex
    {
      [Token(Token = "0x60088C3"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17001357")]
    public List<BondGroupParam> OpenGroupParamList
    {
      [Token(Token = "0x60088C4"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (List<BondGroupParam>) null;
      }
    }

    [Token(Token = "0x60088C5")]
    [Address(RVA = "0x49ED00", Offset = "0x49DB00", VA = "0x1049ED00")]
    private void Awake()
    {
    }

    [Token(Token = "0x60088C6")]
    [Address(RVA = "0x4A0F80", Offset = "0x49FD80", VA = "0x104A0F80")]
    private void Start()
    {
    }

    [Token(Token = "0x60088C7")]
    [Address(RVA = "0x4A10C0", Offset = "0x49FEC0", VA = "0x104A10C0")]
    private void Update()
    {
    }

    [Token(Token = "0x60088C8")]
    [Address(RVA = "0x4A0200", Offset = "0x49F000", VA = "0x104A0200")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60088C9")]
    [Address(RVA = "0x49E940", Offset = "0x49D740", VA = "0x1049E940", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60088CA")]
    [Address(RVA = "0x49F730", Offset = "0x49E530", VA = "0x1049F730")]
    private void Initialized()
    {
    }

    [Token(Token = "0x60088CB")]
    [Address(RVA = "0x4A0430", Offset = "0x49F230", VA = "0x104A0430")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60088CC")]
    [Address(RVA = "0x49F5F0", Offset = "0x49E3F0", VA = "0x1049F5F0")]
    private void CycleGroup()
    {
    }

    [Token(Token = "0x60088CD")]
    [Address(RVA = "0x4A03D0", Offset = "0x49F1D0", VA = "0x104A03D0")]
    private void OnFilterToggleChangeValue(bool isOn)
    {
    }

    [Token(Token = "0x60088CE")]
    [Address(RVA = "0x4A00D0", Offset = "0x49EED0", VA = "0x104A00D0")]
    public void OnClickGroup(BondGroupParam param)
    {
    }

    [Token(Token = "0x60088CF")]
    [Address(RVA = "0x4A01D0", Offset = "0x49EFD0", VA = "0x104A01D0")]
    public void OnClickTargetMember(BondGroupParam param)
    {
    }

    [Token(Token = "0x60088D0")]
    [Address(RVA = "0x4A0BB0", Offset = "0x49F9B0", VA = "0x104A0BB0")]
    public void SetBondMaterialDatas(JSON_BondMaterialDatas[] json)
    {
    }

    [Token(Token = "0x60088D1")]
    [Address(RVA = "0x4A0CD0", Offset = "0x49FAD0", VA = "0x104A0CD0")]
    public void SetBondMissionDatas(JSON_BondMissionData[] json)
    {
    }

    [Token(Token = "0x60088D2")]
    [Address(RVA = "0x49F670", Offset = "0x49E470", VA = "0x1049F670")]
    public static Sprite GetBondGroupListBanner(string _bond_group_iname) => (Sprite) null;

    [Token(Token = "0x60088D3")]
    [Address(RVA = "0x4A1020", Offset = "0x49FE20", VA = "0x104A1020")]
    public bool UnitFilterClear() => new bool();

    [Token(Token = "0x60088D4")]
    [Address(RVA = "0x4A0EF0", Offset = "0x49FCF0", VA = "0x104A0EF0")]
    public bool SetNewUnitSelectFilter(List<string> new_units_filter) => new bool();

    [Token(Token = "0x60088D5")]
    [Address(RVA = "0x49EB00", Offset = "0x49D900", VA = "0x1049EB00")]
    public void ApplyBuffToSelectBondGroupUnits()
    {
    }

    [Token(Token = "0x60088D6")]
    [Address(RVA = "0x49F130", Offset = "0x49DF30", VA = "0x1049F130")]
    public List<SerializeValueBehaviour> CreateMaterilaList(
      BondGroupBuffDetaillParam target,
      SerializeValueBehaviour templete,
      Transform root,
      bool is_can_lv_up,
      string sbv_key_icon,
      string sbv_key_need_amount,
      string sbv_key_have_amount,
      bool is_material_quest = false)
    {
      return (List<SerializeValueBehaviour>) null;
    }

    [Token(Token = "0x60088D7")]
    [Address(RVA = "0x49ED40", Offset = "0x49DB40", VA = "0x1049ED40")]
    private SerializeValueBehaviour CreateContent(
      string item_iname,
      int need_amount,
      SerializeValueBehaviour templete,
      Transform root,
      string sbv_key_icon,
      string sbv_key_need_amount,
      string sbv_key_have_amount,
      bool is_can_convert,
      bool is_material_quest)
    {
      return (SerializeValueBehaviour) null;
    }

    [Token(Token = "0x60088D8")]
    [Address(RVA = "0x4A0020", Offset = "0x49EE20", VA = "0x104A0020")]
    public void MoveOpenUpGroup()
    {
    }

    [Token(Token = "0x60088D9")]
    [Address(RVA = "0x49EAC0", Offset = "0x49D8C0", VA = "0x1049EAC0")]
    public void Animating()
    {
    }

    [Token(Token = "0x60088DA")]
    [Address(RVA = "0x4A00B0", Offset = "0x49EEB0", VA = "0x104A00B0")]
    public void OnAnimeSkip()
    {
    }

    [Token(Token = "0x60088DB")]
    [Address(RVA = "0x4A1100", Offset = "0x49FF00", VA = "0x104A1100")]
    public BondTop()
    {
    }

    [Token(Token = "0x20020D1")]
    private class State_Idle : State<BondTop>
    {
      [Token(Token = "0x60088DE")]
      [Address(RVA = "0x4B4FA0", Offset = "0x4B3DA0", VA = "0x104B4FA0")]
      public State_Idle()
      {
      }
    }

    [Token(Token = "0x20020D2")]
    private class State_MoveTargetBanner : State<BondTop>
    {
      [Token(Token = "0x4008DC2")]
      [FieldOffset(Offset = "0xC")]
      private float startTime;
      [Token(Token = "0x4008DC3")]
      [FieldOffset(Offset = "0x10")]
      private Vector2 startPosition;
      [Token(Token = "0x4008DC4")]
      [FieldOffset(Offset = "0x18")]
      private Vector2 endPosition;
      [Token(Token = "0x4008DC5")]
      [FieldOffset(Offset = "0x20")]
      private bool is_start;

      [Token(Token = "0x60088DF")]
      [Address(RVA = "0x4B4FE0", Offset = "0x4B3DE0", VA = "0x104B4FE0", Slot = "4")]
      public override void Begin(BondTop self)
      {
      }

      [Token(Token = "0x60088E0")]
      [Address(RVA = "0x4B5150", Offset = "0x4B3F50", VA = "0x104B5150", Slot = "5")]
      public override void Update(BondTop self)
      {
      }

      [Token(Token = "0x60088E1")]
      [Address(RVA = "0x4B5280", Offset = "0x4B4080", VA = "0x104B5280")]
      public State_MoveTargetBanner()
      {
      }
    }

    [Token(Token = "0x20020D3")]
    private class State_NewOpenAnimation : State<BondTop>
    {
      [Token(Token = "0x60088E2")]
      [Address(RVA = "0x4B52C0", Offset = "0x4B40C0", VA = "0x104B52C0", Slot = "4")]
      public override void Begin(BondTop self)
      {
      }

      [Token(Token = "0x60088E3")]
      [Address(RVA = "0x4B5320", Offset = "0x4B4120", VA = "0x104B5320", Slot = "5")]
      public override void Update(BondTop self)
      {
      }

      [Token(Token = "0x60088E4")]
      [Address(RVA = "0x4B5360", Offset = "0x4B4160", VA = "0x104B5360")]
      public State_NewOpenAnimation()
      {
      }
    }
  }
}
