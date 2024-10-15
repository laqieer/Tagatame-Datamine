// Decompiled with JetBrains decompiler
// Type: SRPG.FlowWindowController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023C7")]
  public class FlowWindowController
  {
    [Token(Token = "0x400A19C")]
    [FieldOffset(Offset = "0x8")]
    private bool m_Enabled;
    [Token(Token = "0x400A19D")]
    [FieldOffset(Offset = "0xC")]
    private FlowNode m_FlowNode;
    [Token(Token = "0x400A19E")]
    [FieldOffset(Offset = "0x10")]
    private List<FlowWindowBase> m_List;

    [Token(Token = "0x1700158E")]
    public bool enabled
    {
      [Token(Token = "0x6009AEB"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] set
      {
      }
      [Token(Token = "0x6009AEC"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009AED")]
    [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
    public void Initialize(FlowNode node)
    {
    }

    [Token(Token = "0x6009AEE")]
    [Address(RVA = "0x5F0AC0", Offset = "0x5EF8C0", VA = "0x105F0AC0")]
    public void Release()
    {
    }

    [Token(Token = "0x6009AEF")]
    [Address(RVA = "0x5F0BE0", Offset = "0x5EF9E0", VA = "0x105F0BE0")]
    public void Start()
    {
    }

    [Token(Token = "0x6009AF0")]
    [Address(RVA = "0x5F0C70", Offset = "0x5EFA70", VA = "0x105F0C70")]
    public void Update()
    {
    }

    [Token(Token = "0x6009AF1")]
    [Address(RVA = "0x5F0940", Offset = "0x5EF740", VA = "0x105F0940")]
    public void LateUpdate()
    {
    }

    [Token(Token = "0x6009AF2")]
    [Address(RVA = "0x5F05B0", Offset = "0x5EF3B0", VA = "0x105F05B0")]
    public void ActivateOutputLinks(int pinId)
    {
    }

    [Token(Token = "0x6009AF3")]
    [Address(RVA = "0x5F0630", Offset = "0x5EF430", VA = "0x105F0630")]
    public void Add(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x6009AF4")]
    [Address(RVA = "0x5F0B80", Offset = "0x5EF980", VA = "0x105F0B80")]
    public void Remove(FlowWindowBase window)
    {
    }

    [Token(Token = "0x6009AF5")]
    [Address(RVA = "0x5F0720", Offset = "0x5EF520", VA = "0x105F0720")]
    public FlowWindowBase GetWindow(string name) => (FlowWindowBase) null;

    [Token(Token = "0x6009AF6")]
    [Address(RVA = "0x5F07E0", Offset = "0x5EF5E0", VA = "0x105F07E0")]
    public FlowWindowBase GetWindow(System.Type type) => (FlowWindowBase) null;

    [Token(Token = "0x6009AF7")]
    public T GetWindow<T>() where T : FlowWindowBase => (T) null;

    [Token(Token = "0x6009AF8")]
    [Address(RVA = "0x5F08B0", Offset = "0x5EF6B0", VA = "0x105F08B0")]
    public bool IsStartUp() => new bool();

    [Token(Token = "0x6009AF9")]
    [Address(RVA = "0x5F09C0", Offset = "0x5EF7C0", VA = "0x105F09C0")]
    public void OnActivate(int pinId)
    {
    }

    [Token(Token = "0x6009AFA")]
    [Address(RVA = "0x5F0F00", Offset = "0x5EFD00", VA = "0x105F0F00")]
    public FlowWindowController()
    {
    }
  }
}
