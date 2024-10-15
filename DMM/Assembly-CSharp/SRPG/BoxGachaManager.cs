// Decompiled with JetBrains decompiler
// Type: SRPG.BoxGachaManager
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
  [Token(Token = "0x20020FF")]
  [AddComponentMenu("")]
  [FlowNode.Pin(42, "OT BOXをリセットする（BOX内が空）", FlowNode.PinTypes.Output, 42)]
  [FlowNode.Pin(21, "OT 現在の排出状況を表示)", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(40, "IN BOXをリセットする", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(31, "OT 全ステップの詳細を表示", FlowNode.PinTypes.Output, 31)]
  [FlowNode.Pin(30, "IN 全ステップの詳細を表示", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(20, "IN 現在の排出状況を表示", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(41, "OT BOXをリセットする（BOX内が空じゃない）", FlowNode.PinTypes.Output, 41)]
  [FlowNode.Pin(15, "OT 交換しようとしたがBOXが空", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(14, "IN リザルトから交換を選択", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(13, "OT N回交換を選択", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(12, "OT 1回交換を選択", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(11, "IN N回交換を選択", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "IN 1回交換を選択", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1, "OT 表示更新完了", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "IN 表示更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(16, "OT 交換しようとしたがコスト不足", FlowNode.PinTypes.Output, 16)]
  [FlowNode.NodeType("UI/BoxGachaManager", 32741)]
  public class BoxGachaManager : FlowNodePersistent
  {
    [Token(Token = "0x4008EBD")]
    private const int PIN_IN_REFRESH = 0;
    [Token(Token = "0x4008EBE")]
    private const int PIN_OT_REFRESH = 1;
    [Token(Token = "0x4008EBF")]
    private const int PIN_IN_SELECT_EXEC_SINGLE = 10;
    [Token(Token = "0x4008EC0")]
    private const int PIN_IN_SELECT_EXEC_MULTI = 11;
    [Token(Token = "0x4008EC1")]
    private const int PIN_OT_SELECT_EXEC_SINGLE = 12;
    [Token(Token = "0x4008EC2")]
    private const int PIN_OT_SELECT_EXEC_MULTI = 13;
    [Token(Token = "0x4008EC3")]
    private const int PIN_IN_SELECT_EXEC_RESULT = 14;
    [Token(Token = "0x4008EC4")]
    private const int PIN_OT_SELECT_EXEC_BOX_EMPTY = 15;
    [Token(Token = "0x4008EC5")]
    private const int PIN_OT_SELECT_EXEC_COST_SHORT = 16;
    [Token(Token = "0x4008EC6")]
    private const int PIN_IN_SELECT_DRAW_STATUS = 20;
    [Token(Token = "0x4008EC7")]
    private const int PIN_OT_SELECT_DRAW_STATUS = 21;
    [Token(Token = "0x4008EC8")]
    private const int PIN_IN_SELECT_LINEUP = 30;
    [Token(Token = "0x4008EC9")]
    private const int PIN_OT_SELECT_LINEUP = 31;
    [Token(Token = "0x4008ECA")]
    private const int PIN_IN_SELECT_RESET = 40;
    [Token(Token = "0x4008ECB")]
    private const int PIN_OT_SELECT_RESET_NO_EMPTY = 41;
    [Token(Token = "0x4008ECC")]
    private const int PIN_OT_SELECT_RESET_EMPTY = 42;
    [Token(Token = "0x4008ECD")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int SELECT_SINGLE;
    [Token(Token = "0x4008ECE")]
    [FieldOffset(Offset = "0x4")]
    public static readonly int SELECT_MULTI_MAX;
    [Token(Token = "0x4008ECF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button m_SingleButton;
    [Token(Token = "0x4008ED0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button m_MultiButton;
    [Token(Token = "0x4008ED1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button m_ResultButton;
    [Token(Token = "0x4008ED2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject m_Cost;
    [Token(Token = "0x4008ED3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject m_CostResult;
    [Token(Token = "0x4008ED4")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button m_ResetButton;
    [Token(Token = "0x4008ED5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject m_TopImage;
    [Token(Token = "0x4008ED6")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private bool IsAdvanceEvent;
    [Token(Token = "0x4008ED7")]
    [FieldOffset(Offset = "0x38")]
    private GameObject m_CostItemObj;
    [Token(Token = "0x4008ED8")]
    [FieldOffset(Offset = "0x3C")]
    private GameObject m_CostCoinObj;
    [Token(Token = "0x4008ED9")]
    [FieldOffset(Offset = "0x40")]
    private GameObject m_CostGoldObj;
    [Token(Token = "0x4008EDA")]
    [FieldOffset(Offset = "0x44")]
    private GameObject m_CostResultItemObj;
    [Token(Token = "0x4008EDB")]
    [FieldOffset(Offset = "0x48")]
    private GameObject m_CostResultCoinObj;
    [Token(Token = "0x4008EDC")]
    [FieldOffset(Offset = "0x4C")]
    private GameObject m_CostResultGoldObj;
    [Token(Token = "0x4008EDD")]
    [FieldOffset(Offset = "0x50")]
    private bool m_LastMultiToucheEnabled;
    [Token(Token = "0x4008EDE")]
    [FieldOffset(Offset = "0x51")]
    private bool m_LastSelectExecSingle;
    [Token(Token = "0x4008EDF")]
    [FieldOffset(Offset = "0x8")]
    private static BoxGachaManager.BoxGachaStatus m_CurrentBoxGachaStatus;

    [Token(Token = "0x17001388")]
    public static BoxGachaManager.BoxGachaStatus CurrentBoxGachaStatus
    {
      [Token(Token = "0x60089E7"), Address(RVA = "0x4A82A0", Offset = "0x4A70A0", VA = "0x104A82A0")] get
      {
        return (BoxGachaManager.BoxGachaStatus) null;
      }
      [Token(Token = "0x60089E8"), Address(RVA = "0x4A82E0", Offset = "0x4A70E0", VA = "0x104A82E0")] set
      {
      }
    }

    [Token(Token = "0x60089E9")]
    [Address(RVA = "0x4A6B70", Offset = "0x4A5970", VA = "0x104A6B70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60089EA")]
    [Address(RVA = "0x4A6E50", Offset = "0x4A5C50", VA = "0x104A6E50", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x60089EB")]
    [Address(RVA = "0x4A6FD0", Offset = "0x4A5DD0", VA = "0x104A6FD0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60089EC")]
    [Address(RVA = "0x4A6FB0", Offset = "0x4A5DB0", VA = "0x104A6FB0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60089ED")]
    [Address(RVA = "0x4A7000", Offset = "0x4A5E00", VA = "0x104A7000")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60089EE")]
    [Address(RVA = "0x4A6AB0", Offset = "0x4A58B0", VA = "0x104A6AB0")]
    private void DownLoadedPreview(GameObject img_prefab)
    {
    }

    [Token(Token = "0x60089EF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public BoxGachaManager()
    {
    }

    [Token(Token = "0x60089F0")]
    [Address(RVA = "0x4A8240", Offset = "0x4A7040", VA = "0x104A8240")]
    static BoxGachaManager()
    {
    }

    [Token(Token = "0x2002100")]
    public enum BoxGachaCostType : byte
    {
      [Token(Token = "0x4008EE1")] None,
      [Token(Token = "0x4008EE2")] Gold,
      [Token(Token = "0x4008EE3")] Coin,
      [Token(Token = "0x4008EE4")] Item,
    }

    [Token(Token = "0x2002101")]
    public class BoxGachaStatus
    {
      [Token(Token = "0x4008EE5")]
      [FieldOffset(Offset = "0x8")]
      private string iname;
      [Token(Token = "0x4008EE6")]
      [FieldOffset(Offset = "0xC")]
      private int step;
      [Token(Token = "0x4008EE7")]
      [FieldOffset(Offset = "0x10")]
      private int total;
      [Token(Token = "0x4008EE8")]
      [FieldOffset(Offset = "0x14")]
      private int remain;
      [Token(Token = "0x4008EE9")]
      [FieldOffset(Offset = "0x18")]
      private bool reset;
      [Token(Token = "0x4008EEA")]
      [FieldOffset(Offset = "0x19")]
      private BoxGachaManager.BoxGachaCostType cost_type;
      [Token(Token = "0x4008EEB")]
      [FieldOffset(Offset = "0x1C")]
      private string cost_iname;
      [Token(Token = "0x4008EEC")]
      [FieldOffset(Offset = "0x20")]
      private int cost_value;
      [Token(Token = "0x4008EED")]
      [FieldOffset(Offset = "0x24")]
      private int multi_count;
      [Token(Token = "0x4008EEE")]
      [FieldOffset(Offset = "0x28")]
      private int multi_cost;
      [Token(Token = "0x4008EEF")]
      [FieldOffset(Offset = "0x2C")]
      private bool isMax;
      [Token(Token = "0x4008EF0")]
      [FieldOffset(Offset = "0x30")]
      private List<GachaDropData> drops;

      [Token(Token = "0x17001389")]
      public string Iname
      {
        [Token(Token = "0x60089F1"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700138A")]
      public int Step
      {
        [Token(Token = "0x60089F2"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x1700138B")]
      public int Total
      {
        [Token(Token = "0x60089F3"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x1700138C")]
      public int Remain
      {
        [Token(Token = "0x60089F4"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x1700138D")]
      public bool IsReset
      {
        [Token(Token = "0x60089F5"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x1700138E")]
      public BoxGachaManager.BoxGachaCostType CostType
      {
        [Token(Token = "0x60089F6"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
        {
          return new BoxGachaManager.BoxGachaCostType();
        }
      }

      [Token(Token = "0x1700138F")]
      public string CostIname
      {
        [Token(Token = "0x60089F7"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001390")]
      public int CostValue
      {
        [Token(Token = "0x60089F8"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001391")]
      public bool IsBoxEmpty
      {
        [Token(Token = "0x60089F9"), Address(RVA = "0x4A9D90", Offset = "0x4A8B90", VA = "0x104A9D90")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001392")]
      public int MultiCount
      {
        [Token(Token = "0x60089FA"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001393")]
      public int MultiCost
      {
        [Token(Token = "0x60089FB"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001394")]
      public bool IsSelectMulti
      {
        [Token(Token = "0x60089FC"), Address(RVA = "0x4A9DA0", Offset = "0x4A8BA0", VA = "0x104A9DA0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001395")]
      public List<GachaDropData> Drops
      {
        [Token(Token = "0x60089FD"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
        {
          return (List<GachaDropData>) null;
        }
      }

      [Token(Token = "0x17001396")]
      public int LastSelectedValue
      {
        [Token(Token = "0x60089FE"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
        {
          return new int();
        }
        [Token(Token = "0x60089FF"), Address(RVA = "0x49D280", Offset = "0x49C080", VA = "0x1049D280")] set
        {
        }
      }

      [Token(Token = "0x17001397")]
      public bool IsMax
      {
        [Token(Token = "0x6008A00"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
        {
          return new bool();
        }
        [Token(Token = "0x6008A01"), Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")] set
        {
        }
      }

      [Token(Token = "0x6008A02")]
      [Address(RVA = "0x4A96A0", Offset = "0x4A84A0", VA = "0x104A96A0")]
      public void Deserialize(ReqBoxStatus.Response json)
      {
      }

      [Token(Token = "0x6008A03")]
      [Address(RVA = "0x4A9900", Offset = "0x4A8700", VA = "0x104A9900")]
      public void Deserialize(ReqBoxExec.Response json)
      {
      }

      [Token(Token = "0x6008A04")]
      [Address(RVA = "0x4A9590", Offset = "0x4A8390", VA = "0x104A9590")]
      public void Deserialize(ReqBoxReset.Response json)
      {
      }

      [Token(Token = "0x6008A05")]
      [Address(RVA = "0x4A9C20", Offset = "0x4A8A20", VA = "0x104A9C20")]
      public void Reset()
      {
      }

      [Token(Token = "0x6008A06")]
      [Address(RVA = "0x4A9B40", Offset = "0x4A8940", VA = "0x104A9B40")]
      public bool IsCostShort(bool is_multi = false) => new bool();

      [Token(Token = "0x6008A07")]
      [Address(RVA = "0x4A9430", Offset = "0x4A8230", VA = "0x104A9430")]
      private void CalcMaxExec(ref int count, ref int cost)
      {
      }

      [Token(Token = "0x6008A08")]
      [Address(RVA = "0x4A9CE0", Offset = "0x4A8AE0", VA = "0x104A9CE0")]
      public BoxGachaStatus()
      {
      }
    }
  }
}
