// Decompiled with JetBrains decompiler
// Type: SRPG.BoxGachaDrawStatusWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020EF")]
  [FlowNode.NodeType("UI/BoxGachaDrawStatusWindow", 32741)]
  [FlowNode.Pin(100, "ラインナップ更新", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "ラインナップ更新終了", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class BoxGachaDrawStatusWindow : FlowNodePersistent
  {
    [Token(Token = "0x4008E66")]
    public const int PIN_IN_REFRESH = 100;
    [Token(Token = "0x4008E67")]
    public const int PIN_OT_REFRESH = 101;
    [Token(Token = "0x4008E68")]
    [FieldOffset(Offset = "0x18")]
    public BoxGachaLineupListWindow.SerializeParam m_LineupListWindowparam;
    [Token(Token = "0x4008E69")]
    [FieldOffset(Offset = "0x1C")]
    private FlowWindowController m_WindowController;
    [Token(Token = "0x4008E6A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text ListTitle;
    [Token(Token = "0x4008E6B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button ResetBtn;

    [Token(Token = "0x600898C")]
    [Address(RVA = "0x4A4940", Offset = "0x4A3740", VA = "0x104A4940", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600898D")]
    [Address(RVA = "0x4A4C60", Offset = "0x4A3A60", VA = "0x104A4C60")]
    private void Start()
    {
    }

    [Token(Token = "0x600898E")]
    [Address(RVA = "0x4A4C30", Offset = "0x4A3A30", VA = "0x104A4C30", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600898F")]
    [Address(RVA = "0x4A4CF0", Offset = "0x4A3AF0", VA = "0x104A4CF0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008990")]
    [Address(RVA = "0x4A49A0", Offset = "0x4A37A0", VA = "0x104A49A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6008991")]
    [Address(RVA = "0x4A4D20", Offset = "0x4A3B20", VA = "0x104A4D20")]
    public BoxGachaDrawStatusWindow()
    {
    }
  }
}
