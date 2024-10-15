// Decompiled with JetBrains decompiler
// Type: SRPG.BoxGachaLineupWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020F9")]
  [FlowNode.Pin(100, "ラインナップ更新", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "ラインナップ更新終了", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("UI/BoxGachaLineupWindow", 32741)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class BoxGachaLineupWindow : FlowNodePersistent
  {
    [Token(Token = "0x4008E9A")]
    public const int PIN_IN_INITALIZE = 1;
    [Token(Token = "0x4008E9B")]
    public const int PIN_IN_REFRESH = 100;
    [Token(Token = "0x4008E9C")]
    public const int PIN_OT_REFRESH = 101;
    [Token(Token = "0x4008E9D")]
    [FieldOffset(Offset = "0x18")]
    public BoxGachaLineupListWindow.SerializeParam m_LineupListWindowparam;
    [Token(Token = "0x4008E9E")]
    [FieldOffset(Offset = "0x1C")]
    private FlowWindowController m_WindowController;
    [Token(Token = "0x4008E9F")]
    [FieldOffset(Offset = "0x0")]
    private static BoxGachaLineupWindow m_Instnace;
    [Token(Token = "0x4008EA0")]
    [FieldOffset(Offset = "0x20")]
    private BoxGachaLineupWindow.BoxAllLinupParam m_Lineup;
    [Token(Token = "0x4008EA1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Toggle StartTabToggle;
    [Token(Token = "0x4008EA2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Toggle EndTabToggle;
    [Token(Token = "0x4008EA3")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Toggle TemplateTabToggle;

    [Token(Token = "0x17001384")]
    public static BoxGachaLineupWindow Instance
    {
      [Token(Token = "0x60089CD"), Address(RVA = "0x4A6A80", Offset = "0x4A5880", VA = "0x104A6A80")] get
      {
        return (BoxGachaLineupWindow) null;
      }
    }

    [Token(Token = "0x60089CE")]
    [Address(RVA = "0x4A4940", Offset = "0x4A3740", VA = "0x104A4940", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x60089CF")]
    [Address(RVA = "0x4A6520", Offset = "0x4A5320", VA = "0x104A6520")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60089D0")]
    [Address(RVA = "0x4A64A0", Offset = "0x4A52A0", VA = "0x104A64A0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60089D1")]
    [Address(RVA = "0x4A67C0", Offset = "0x4A55C0", VA = "0x104A67C0")]
    private void Start()
    {
    }

    [Token(Token = "0x60089D2")]
    [Address(RVA = "0x4A4C30", Offset = "0x4A3A30", VA = "0x104A4C30", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x60089D3")]
    [Address(RVA = "0x4A4CF0", Offset = "0x4A3AF0", VA = "0x104A4CF0")]
    private void Update()
    {
    }

    [Token(Token = "0x60089D4")]
    [Address(RVA = "0x4A6440", Offset = "0x4A5240", VA = "0x104A6440", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60089D5")]
    [Address(RVA = "0x4A5D40", Offset = "0x4A4B40", VA = "0x104A5D40")]
    public void Inialize()
    {
    }

    [Token(Token = "0x60089D6")]
    [Address(RVA = "0x4A66E0", Offset = "0x4A54E0", VA = "0x104A66E0")]
    private void OnToggleChange(Toggle toggle)
    {
    }

    [Token(Token = "0x60089D7")]
    [Address(RVA = "0x4A65A0", Offset = "0x4A53A0", VA = "0x104A65A0")]
    private void OnSelect(int index)
    {
    }

    [Token(Token = "0x60089D8")]
    [Address(RVA = "0x4A5BB0", Offset = "0x4A49B0", VA = "0x104A5BB0")]
    public void DeserializeAllLineup(ReqBoxLineup.Response json)
    {
    }

    [Token(Token = "0x60089D9")]
    [Address(RVA = "0x4A6A10", Offset = "0x4A5810", VA = "0x104A6A10")]
    public BoxGachaLineupWindow()
    {
    }

    [Token(Token = "0x20020FA")]
    public class BoxAllLinupParam
    {
      [Token(Token = "0x4008EA4")]
      [FieldOffset(Offset = "0x8")]
      private string m_BoxIname;
      [Token(Token = "0x4008EA5")]
      [FieldOffset(Offset = "0xC")]
      private int m_TotalStep;
      [Token(Token = "0x4008EA6")]
      [FieldOffset(Offset = "0x10")]
      private JSON_BoxGachaSteps[] m_Steps;

      [Token(Token = "0x17001385")]
      public string box_iname
      {
        [Token(Token = "0x60089DD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001386")]
      public int total_step
      {
        [Token(Token = "0x60089DE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001387")]
      public JSON_BoxGachaSteps[] steps
      {
        [Token(Token = "0x60089DF"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (JSON_BoxGachaSteps[]) null;
        }
      }

      [Token(Token = "0x60089E0")]
      [Address(RVA = "0x4A47E0", Offset = "0x4A35E0", VA = "0x104A47E0")]
      public bool Deserialize(ReqBoxLineup.Response json) => new bool();

      [Token(Token = "0x60089E1")]
      [Address(RVA = "0x4A48F0", Offset = "0x4A36F0", VA = "0x104A48F0")]
      public BoxAllLinupParam()
      {
      }
    }
  }
}
