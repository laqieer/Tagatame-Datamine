// Decompiled with JetBrains decompiler
// Type: SRPG.FlowCommonWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023C3")]
  [FlowNode.NodeType("UI/FlowCommonWindow", 32741)]
  [FlowNode.Pin(500, "長押し", FlowNode.PinTypes.Input, 500)]
  [FlowNode.Pin(50, "開始", FlowNode.PinTypes.Output, 50)]
  [FlowNode.Pin(490, "選択した", FlowNode.PinTypes.Output, 490)]
  [FlowNode.Pin(100, "ウィンド開く", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(200, "ウィンド閉じる", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(190, "開く", FlowNode.PinTypes.Output, 190)]
  [FlowNode.Pin(290, "閉じる", FlowNode.PinTypes.Output, 290)]
  [FlowNode.Pin(291, "閉じた", FlowNode.PinTypes.Output, 291)]
  [FlowNode.Pin(191, "開いた", FlowNode.PinTypes.Output, 191)]
  [AddComponentMenu("")]
  [FlowNode.Pin(590, "長押しした", FlowNode.PinTypes.Output, 590)]
  [FlowNode.Pin(390, "更新した", FlowNode.PinTypes.Output, 390)]
  [FlowNode.Pin(400, "選択", FlowNode.PinTypes.Input, 400)]
  [FlowNode.Pin(300, "更新", FlowNode.PinTypes.Input, 300)]
  public class FlowCommonWindow : FlowNodePersistent
  {
    [Token(Token = "0x400A186")]
    public const int OUTPUT_WINDOW_START = 50;
    [Token(Token = "0x400A187")]
    public const int INPUT_WINDOW_OPEN = 100;
    [Token(Token = "0x400A188")]
    public const int OUTPUT_WINDOW_OPEN = 190;
    [Token(Token = "0x400A189")]
    public const int OUTPUT_WINDOW_OPENED = 191;
    [Token(Token = "0x400A18A")]
    public const int INPUT_WINDOW_CLOSE = 200;
    [Token(Token = "0x400A18B")]
    public const int OUTPUT_WINDOW_CLOSE = 290;
    [Token(Token = "0x400A18C")]
    public const int OUTPUT_WINDOW_CLOSED = 291;
    [Token(Token = "0x400A18D")]
    public const int INPUT_WINDOW_REFRESH = 300;
    [Token(Token = "0x400A18E")]
    public const int OUTPUT_WINDOW_REFRESH = 390;
    [Token(Token = "0x400A18F")]
    public const int INPUT_WINDOW_SELECT = 400;
    [Token(Token = "0x400A190")]
    public const int OUTPUT_WINDOW_SELECT = 490;
    [Token(Token = "0x400A191")]
    public const int INPUT_WINDOW_HOLD = 500;
    [Token(Token = "0x400A192")]
    public const int OUTPUT_WINDOW_HOLD = 590;
    [Token(Token = "0x400A193")]
    [FieldOffset(Offset = "0x18")]
    public FlowCommonWindow.RootWindow.SerializeParam m_RootWindowParam;
    [Token(Token = "0x400A194")]
    [FieldOffset(Offset = "0x1C")]
    private FlowWindowController m_WindowController;
    [Token(Token = "0x400A195")]
    [FieldOffset(Offset = "0x20")]
    private FlowCommonWindow.RootWindow m_RootWindow;

    [Token(Token = "0x17001589")]
    public FlowCommonWindow.RootWindow rootWindow
    {
      [Token(Token = "0x6009AD1"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (FlowCommonWindow.RootWindow) null;
      }
    }

    [Token(Token = "0x6009AD2")]
    [Address(RVA = "0x5ECA00", Offset = "0x5EB800", VA = "0x105ECA00", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6009AD3")]
    [Address(RVA = "0x5ECDF0", Offset = "0x5EBBF0", VA = "0x105ECDF0")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x6009AD4")]
    [Address(RVA = "0x5ECD00", Offset = "0x5EBB00", VA = "0x105ECD00", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6009AD5")]
    [Address(RVA = "0x4A4CF0", Offset = "0x4A3AF0", VA = "0x104A4CF0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009AD6")]
    [Address(RVA = "0x5ECB70", Offset = "0x5EB970", VA = "0x105ECB70")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6009AD7")]
    [Address(RVA = "0x5ECBF0", Offset = "0x5EB9F0", VA = "0x105ECBF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009AD8")]
    [Address(RVA = "0x5ECE60", Offset = "0x5EBC60", VA = "0x105ECE60")]
    public FlowCommonWindow()
    {
    }

    [Token(Token = "0x20023C4")]
    public class RootWindow : FlowWindowBase
    {
      [Token(Token = "0x400A196")]
      [FieldOffset(Offset = "0x30")]
      private EventCall m_CustomEvent;
      [Token(Token = "0x400A197")]
      [FieldOffset(Offset = "0x34")]
      private SerializeValueList m_ValueList;
      [Token(Token = "0x400A198")]
      [FieldOffset(Offset = "0x38")]
      private bool m_Destroy;

      [Token(Token = "0x1700158A")]
      public override string name
      {
        [Token(Token = "0x6009AD9"), Address(RVA = "0x5F3ED0", Offset = "0x5F2CD0", VA = "0x105F3ED0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6009ADA")]
      [Address(RVA = "0x5F3A10", Offset = "0x5F2810", VA = "0x105F3A10", Slot = "5")]
      public override void Initialize(FlowWindowBase.SerializeParamBase param)
      {
      }

      [Token(Token = "0x6009ADB")]
      [Address(RVA = "0x5EFCD0", Offset = "0x5EEAD0", VA = "0x105EFCD0", Slot = "6")]
      public override void Release()
      {
      }

      [Token(Token = "0x6009ADC")]
      [Address(RVA = "0x5F3E60", Offset = "0x5F2C60", VA = "0x105F3E60", Slot = "7")]
      public override void Start()
      {
      }

      [Token(Token = "0x6009ADD")]
      [Address(RVA = "0x5F3EA0", Offset = "0x5F2CA0", VA = "0x105F3EA0", Slot = "8")]
      public override int Update() => new int();

      [Token(Token = "0x6009ADE")]
      [Address(RVA = "0x5F3DA0", Offset = "0x5F2BA0", VA = "0x105F3DA0")]
      private void OnEvent(string key)
      {
      }

      [Token(Token = "0x6009ADF")]
      [Address(RVA = "0x5F3C10", Offset = "0x5F2A10", VA = "0x105F3C10", Slot = "9")]
      public override int OnActivate(int pinId) => new int();

      [Token(Token = "0x6009AE0")]
      [Address(RVA = "0x5F3E20", Offset = "0x5F2C20", VA = "0x105F3E20", Slot = "10")]
      protected override int OnOpened() => new int();

      [Token(Token = "0x6009AE1")]
      [Address(RVA = "0x5F3D50", Offset = "0x5F2B50", VA = "0x105F3D50", Slot = "11")]
      protected override int OnClosed() => new int();

      [Token(Token = "0x6009AE2")]
      [Address(RVA = "0x5F0450", Offset = "0x5EF250", VA = "0x105F0450")]
      public RootWindow()
      {
      }

      [Token(Token = "0x20023C5")]
      [Serializable]
      public class SerializeParam : FlowWindowBase.SerializeParamBase
      {
        [Token(Token = "0x1700158B")]
        public override System.Type type
        {
          [Token(Token = "0x6009AE3"), Address(RVA = "0x5F3F50", Offset = "0x5F2D50", VA = "0x105F3F50", Slot = "4")] get
          {
            return (System.Type) null;
          }
        }

        [Token(Token = "0x6009AE4")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public SerializeParam()
        {
        }
      }
    }
  }
}
